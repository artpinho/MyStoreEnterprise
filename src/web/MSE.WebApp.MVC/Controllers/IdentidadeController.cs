using Microsoft.AspNetCore.Mvc;
using MSE.WebApp.MVC.Models;
using MSE.WebApp.MVC.Services;


namespace MSE.WebApp.MVC.Controllers
{
    public class IdentidadeController : Controller
    {
        private readonly IAutenticacaoService _autentitacacaoService;

        public IdentidadeController(IAutenticacaoService autentitacacaoService)
        {
            _autentitacacaoService = autentitacacaoService;
        }

        [HttpGet]
        [Route("nova-conta")]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [Route("nova-conta")]
        public async Task<IActionResult> Registro(UsuarioRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid) return View(usuarioRegistro);

            // Chamada API
            var response = await _autentitacacaoService.Registro(usuarioRegistro);

            if (false) return View(usuarioRegistro);


            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(Models.UsuarioLogin usuarioLogin)
        {
            if (!ModelState.IsValid) return View(usuarioLogin);

            // Chamada API
            var response = await _autentitacacaoService.Login(usuarioLogin);

            if (false) return View(usuarioLogin);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("sair")]
        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
