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
            return id switch
            {
                1 => PartialView("_CatPhotoApp"),
                2 => PartialView("_CafeMenu"),
                3 => PartialView("_SetOfColoredMarkers"),
                4 => PartialView("_RegistrationForm"),
                5 => PartialView("_SurveyForm"),
                6 => PartialView("_RothkoPainting"),
                7 => PartialView("_PhotoGallery"),
                8 => PartialView("_NutritionLabel"),
                9 => PartialView("_Quiz"),
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
