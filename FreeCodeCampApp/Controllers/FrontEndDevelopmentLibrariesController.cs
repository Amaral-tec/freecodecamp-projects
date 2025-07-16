using FreeCodeCampApp.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace FreeCodeCampApp.Controllers
{
    public class FrontEndDevelopmentLibrariesController : Controller
    {
        [HttpGet]
        public IActionResult OpenProject(Projects projects)
        {
            return projects switch
            {
                Projects.BootstrapFluidContainers => PartialView("_BootstrapFluidContainers"),
                Projects.BootstrapCreateCustomHeading => PartialView("_BootstrapCreateCustomHeading"),
                Projects.JQueryScriptTagsDocumentReadyWork => PartialView("_JQueryScriptTagsDocumentReadyWork"),
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
