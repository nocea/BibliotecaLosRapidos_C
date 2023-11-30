using Microsoft.AspNetCore.Mvc;
using Poyecto_Gestor_Biblioteca_Web_Los_Rapidos.Models;

namespace Poyecto_Gestor_Biblioteca_Web_Los_Rapidos.Controllers
{
    public class ControladorAdmin : Controller
    {
        public IActionResult irAdmin()
        {
            return View("~/Views/Home/Administracion.cshtml");
        }
        public IActionResult irUsuario()
        {
            List<Usuario> listaUsuarios = new List<Usuario>
            {
                new Usuario { Nombre = "Paco", Apellidos = "Jimenez", Dni = "123", Email = "paco@gmail.com", Telefono = "12312312" }
                
            };

            return View("~/Views/Home/listaUsuarios.cshtml",listaUsuarios); 
        }
        public IActionResult irPrestamo()
        {
            List<Prestamo> listaPrestamos = new List<Prestamo>
            {
                new Prestamo { Libro = "libro1", Usuario = "usuario1", FechaInicio = "3123123", FechaFin = "31231", FechaEntrega = "12312312",Estado = "leyendo" }

            };
            return View("~/Views/Home/listaPrestamos.cshtml",listaPrestamos);
        }
    }
}
