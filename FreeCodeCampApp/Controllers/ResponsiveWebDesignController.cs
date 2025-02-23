using Microsoft.AspNetCore.Mvc;

namespace FreeCodeCampApp.Controllers
{
    public class ResponsiveWebDesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OpenProject(int id)
        {
            if (id == 1)
            {
                return PartialView("_LearnHTMLbyBuildingaCatPhotoApp");
            }

            return Json(new { error = true, mensagem = "Project not found!" });
        }

    }
}
