using System;
using System.Collections.Generic;
using CineGest.BE;
using CineGest.DAL;

namespace CineGest.BLL
{
    public class UsuarioBLL
    {
        public const string RolAdmin = "ADMIN";
        public const string RolVendedor = "VENDEDOR";
        public static readonly string[] Roles = { RolAdmin, RolVendedor };

        private readonly UsuarioDAL _dal = new UsuarioDAL();

        public static Usuario UsuarioActual { get; private set; }
        public static bool EsAdmin => UsuarioActual != null && UsuarioActual.Rol == RolAdmin;

        // ==========================================================
        // LOGIN / LOGOUT
        // ==========================================================
        public Usuario Login(string nombreUsuario, string password)
        {
            nombreUsuario = (nombreUsuario ?? "").Trim();
            if (nombreUsuario.Length == 0 || string.IsNullOrEmpty(password))
                throw new InvalidOperationException("Ingresá usuario y contraseña.");

            var usuario = _dal.ObtenerPorNombre(nombreUsuario);

            if (usuario == null ||
                !string.Equals(usuario.PasswordHash, Seguridad.Sha256(password), StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Usuario o contraseña incorrectos.");

            usuario.PasswordHash = null;
            UsuarioActual = usuario;
            return usuario;
        }

        public void CerrarSesion()
        {
            UsuarioActual = null;
        }

        // ==========================================================
        // LISTAR
        // ==========================================================
        public List<Usuario> Listar() => _dal.Listar();

        public Usuario ObtenerPorId(int id) => _dal.ObtenerPorId(id);

        // ==========================================================
        // ALTA
        // ==========================================================
        public int Alta(string nombreUsuario, string password, string rol)
        {
            if (!EsAdmin)
                throw new InvalidOperationException("Solo un administrador puede crear usuarios.");

            nombreUsuario = (nombreUsuario ?? "").Trim();
            rol = (rol ?? "").Trim().ToUpperInvariant();

            if (nombreUsuario.Length < 3 || nombreUsuario.Length > 50)
                throw new InvalidOperationException("El nombre de usuario debe tener entre 3 y 50 caracteres.");
            if (password == null || password.Length < 4)
                throw new InvalidOperationException("La contraseña debe tener al menos 4 caracteres.");
            if (Array.IndexOf(Roles, rol) < 0)
                throw new InvalidOperationException("El rol debe ser ADMIN o VENDEDOR.");
            if (_dal.ExisteNombre(nombreUsuario))
                throw new InvalidOperationException("Ya existe un usuario con ese nombre.");

            return _dal.Insertar(new Usuario
            {
                NombreUsuario = nombreUsuario,
                PasswordHash = Seguridad.Sha256(password),
                Rol = rol
            });
        }

        // ==========================================================
        // BAJA (eliminar usuario)
        // ==========================================================
        public void Baja(int id)
        {
            if (!EsAdmin)
                throw new InvalidOperationException("Solo un administrador puede eliminar usuarios.");

            if (id <= 0)
                throw new InvalidOperationException("Seleccioná un usuario para eliminar.");

            var usuario = _dal.ObtenerPorId(id);
            if (usuario == null)
                throw new InvalidOperationException("El usuario no existe.");

            // Proteger el usuario maestro
            if (string.Equals(usuario.NombreUsuario, "ADMIN", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("No se puede eliminar el usuario ADMIN principal.");

            // No permitir que el usuario logueado se elimine a sí mismo
            if (UsuarioActual != null && UsuarioActual.Id == id)
                throw new InvalidOperationException("No podés eliminar tu propio usuario en sesión.");

            _dal.Eliminar(id);
        }
        // ==========================================================
        // CAMBIAR CONTRASEÑA
        // ==========================================================
        public void CambiarContrasena(int idUsuario, string passActual, string nuevaPass)
        {
            // 1. Validaciones básicas
            if (idUsuario <= 0)
                throw new InvalidOperationException("Usuario inválido.");
            if (string.IsNullOrWhiteSpace(passActual))
                throw new InvalidOperationException("Debe ingresar su contraseña actual.");
            if (string.IsNullOrWhiteSpace(nuevaPass) || nuevaPass.Length < 4)
                throw new InvalidOperationException("La nueva contraseña debe tener al menos 4 caracteres.");

            // 2. Obtener el usuario de la base de datos
            var usuario = _dal.ObtenerPorId(idUsuario);
            if (usuario == null)
                throw new InvalidOperationException("El usuario no existe en el sistema.");

            // 3. Verificar que la contraseña actual sea correcta
            string hashPassActual = Seguridad.Sha256(passActual);
            if (!string.Equals(usuario.PasswordHash, hashPassActual, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("La contraseña actual es incorrecta.");

            // 4. Evitar que la nueva contraseña sea igual a la actual
            string hashNuevaPass = Seguridad.Sha256(nuevaPass);
            if (string.Equals(usuario.PasswordHash, hashNuevaPass, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("La nueva contraseña debe ser diferente a la actual.");

            // 5. Actualizar en la base de datos
            _dal.ActualizarPassword(idUsuario, hashNuevaPass);
        }
    }
}