using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Poyecto_Gestor_Biblioteca_Web_Los_Rapidos.Controllers
{
    public class LoginController : Controller
    {

        
        // GET: LoginController
        public IActionResult Login()
        {
            // Lógica de la acción (si es necesario)
            return View("~/Views/Home/Login.cshtml");// Devuelve la vista asociada
        }

        public IActionResult Registro()
        {
            // Lógica de la acción (si es necesario)
            return View("~/Views/Home/Registro.cshtml");
        }

        public IActionResult OlvidaContraseña()
        {
            // Lógica de la acción (si es necesario)
            return View("~/Views/Home/OlvidaContraseña.cshtml");
        }
    }
}
