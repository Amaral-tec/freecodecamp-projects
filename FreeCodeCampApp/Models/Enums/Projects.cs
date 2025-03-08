using System.ComponentModel.DataAnnotations;

namespace FreeCodeCampApp.Models.Enums
{
    public enum Projects
    {
        //Responsive Web Design
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
        BalanceSheet = 10,
        [Display(Name = "Cat Painting")]
        CatPainting = 11,
        [Display(Name = "Piano")]
        Piano = 12,
        [Display(Name = "City Skyline")]
        CitySkyline = 13,
        [Display(Name = "Magazine")]
        Magazine = 14,
        [Display(Name = "FerrisWheel")]
        FerrisWheel = 15,
        [Display(Name = "Penguin")]
        Penguin = 16,

        //JavaScript Algorithms and Data Structures
        [Display(Name = "Pyramid Generator")]
        PyramidGenerator = 17,
        [Display(Name = "Gradebook App")]
        GradebookApp = 18,
    }
}
