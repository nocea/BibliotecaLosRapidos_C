using Microsoft.AspNetCore.Mvc;

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
            return View("~/Views/Home/listaUsuarios.cshtml");
        }
        public IActionResult irPrestamo()
        {
            return View("~/Views/Home/listaPrestamos.cshtml");
        }
    }
}
