using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
