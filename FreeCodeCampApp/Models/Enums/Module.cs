using System.ComponentModel.DataAnnotations;

namespace FreeCodeCampApp.Models.Enums
{
    public enum Module
    {
        [Display(Name = "Responsive Web Design")]
        ResponsiveWebDesign = 1,
        [Display(Name = "JavaScript Algorithms and Data Structures")]
        JavaScriptAlgorithmsDataStructures = 2,
    }
}
