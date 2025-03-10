using FreeCodeCampApp.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace FreeCodeCampApp.Controllers
{
    public class JavaScriptAlgorithmsDataStructuresController : Controller
    {
        [HttpGet]
        public IActionResult OpenProject(Projects projects)
        {
            return projects switch
            {
                Projects.PyramidGenerator => PartialView("_PyramidGenerator"),
                Projects.GradebookApp => PartialView("_GradebookApp"),
                Projects.RolePlayingGame => PartialView("_RolePlayingGame"),
                Projects.RandomBackgroundColorChanger => PartialView("_RandomBackgroundColorChanger"),
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
