using FreeCodeCampApp.Models.Enums;
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
        public IActionResult OpenProject(Projects projects)
        {
            return projects switch
            {
                Projects.CatPhotoApp => PartialView("_CatPhotoApp"),
                Projects.CafeMenu => PartialView("_CafeMenu"),
                Projects.SetOfColoredMarkers => PartialView("_SetOfColoredMarkers"),
                Projects.RegistrationForm => PartialView("_RegistrationForm"),
                Projects.SurveyForm => PartialView("_SurveyForm"),
                Projects.RothkoPainting => PartialView("_RothkoPainting"),
                Projects.PhotoGallery => PartialView("_PhotoGallery"),
                Projects.NutritionLabel => PartialView("_NutritionLabel"),
                Projects.Quiz => PartialView("_Quiz"),
                Projects.BalanceSheet => PartialView("_BalanceSheet"),
                Projects.CatPainting => PartialView("_CatPainting"),
                Projects.Piano => PartialView("_Piano"),
                Projects.CitySkyline => PartialView("_CitySkyline"),
                Projects.Magazine => PartialView("_Magazine"),
                Projects.FerrisWheel => PartialView("_FerrisWheel"),
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
