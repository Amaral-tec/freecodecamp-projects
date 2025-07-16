using FreeCodeCampApp.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace FreeCodeCampApp.Controllers
{
    public class FrontEndDevelopmentLibrariesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OpenProject(Projects projects)
        {
            return projects switch
            {
                Projects.BootstrapFluidContainers => PartialView("_BootstrapFluidContainers"),
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
