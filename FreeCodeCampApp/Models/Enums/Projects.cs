using System.ComponentModel.DataAnnotations;

namespace FreeCodeCampApp.Models.Enums
{
    public enum Projects
    {
        [Display(Name = "Cat Photo App")]
        CatPhotoApp = 1,
        [Display(Name = "Cafe Menu")]
        CafeMenu = 2,
        [Display(Name = "Set Of Colored Markers")]
        SetOfColoredMarkers = 3,
        [Display(Name = "Registration Form")]
        RegistrationForm = 4,
        [Display(Name = "Survey Form")]
        SurveyForm = 5,
        [Display(Name = "Rothko Painting")]
        RothkoPainting = 6,
        [Display(Name = "Photo Gallery")]
        PhotoGallery = 7,
        [Display(Name = "Nutrition Label")]
        NutritionLabel = 8,
        [Display(Name = "Quiz")]
        Quiz = 9,
        [Display(Name = "Balance Sheet")]
        BalanceSheet = 11,
        [Display(Name = "Cat Painting")]
        CatPainting = 12,
        [Display(Name = "Piano")]
        Piano = 13,
        [Display(Name = "City Skyline")]
        CitySkyline = 15,
        [Display(Name = "Magazine")]
        Magazine = 16,
        [Display(Name = "FerrisWheel")]
        FerrisWheel = 17
    }
}
