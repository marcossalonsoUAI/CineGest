# CineGest

Sistema de gestión de un cine: películas, salas, funciones, clientes y venta de entradas.
Trabajo práctico integrador.

## Integrantes

| Hector |
| Gerardo |
| Nicolas |
| Marcos |

## Estructura del repositorio

```
CineGest/
├── database/
│   └── CineGest.sql      Script de creación de la base (tablas, restricciones, datos de salas)
├── docs/                 Diagramas, documentación y material para la defensa
└── src/                  Solución de Visual Studio (capas Presentación, Negocio y Datos)
```

## Cómo levantar el proyecto

1. Clonar el repo:
   ```
   git clone <URL-del-repo>
   ```
2. Abrir `database/CineGest.sql` en SQL Server Management Studio y ejecutarlo. Crea la base `CineGest` en la ubicación por defecto de tu instancia.
3. Abrir la solución que está en `src/` con Visual Studio.
4. Ajustar la cadena de conexión en `App.config` al nombre de tu servidor (por ejemplo `.\SQLEXPRESS` o `(localdb)\MSSQLLocalDB`).

## Base de datos

| Tabla | Función |
| PELICULA | Películas disponibles |
| SALA | Salas del cine |
| FUNCION | Película + sala + fecha/hora + precio |
| CLIENTE | Clientes |
| VENTA | Compras realizadas |
| ENTRADA | Entradas de cada venta |

## Reglas de negocio

| Regla | Descripción | Dónde se valida |
|---|---|---| 
| RN01 | La duración de una película debe ser mayor a cero | BD (`CK_PELICULA_DURACION`) + Negocio |
| RN02 | No se pueden programar funciones de películas inactivas | Negocio |
| RN03 | No se pueden programar dos funciones superpuestas en una misma sala | Negocio |
| RN04 | No se pueden realizar ventas para funciones inactivas | Negocio |
| RN05 | No se puede vender un asiento ya vendido para esa función | BD (`UX_ENTRADA_FUNCION_ASIENTO`) + Negocio |
| RN06 | Una venta debe contener al menos una entrada | Negocio |
| RN07 | El total de la venta debe coincidir con la suma de sus entradas | Negocio |
| RN08 | El precio de una entrada debe ser mayor a cero | BD (`CK_ENTRADA_PRECIO`) + Negocio |

## Transacción principal

La venta de entradas: se inserta la `VENTA`, se obtiene su ID, se insertan las `ENTRADA` y se confirma.
Si falla cualquier entrada, se deshace toda la operación (`SqlTransaction` / `TransactionScope`).

## Forma de trabajo con Git

- `main` siempre tiene que compilar. Nadie pushea directo a `main`.
- Cada uno trabaja en su rama y abre un Pull Request para integrarla:
  - `feature/peliculas-salas`
  - `feature/funciones`
  - `feature/clientes-consultas`
  - `feature/venta-entradas`
- Antes de empezar a trabajar cada día: `git checkout main`, `git pull`, volver a tu rama y `git merge main`.
- Si cambian la base de datos, actualicen `database/CineGest.sql` en el mismo commit y avisen al grupo.
