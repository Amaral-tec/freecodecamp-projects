using System.ComponentModel.DataAnnotations;

namespace FreeCodeCampApp.Models.Enums
{
    public enum Projects
    {
        #region Responsive Web Design
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

        #endregion

        #region JavaScript Algorithms and Data Structures
        [Display(Name = "Pyramid Generator")]
        PyramidGenerator = 17,
        [Display(Name = "Gradebook App")]
        GradebookApp = 18,
        [Display(Name = "Role Playing Game")]
        RolePlayingGame = 19,
        [Display(Name = "Random Background Color Changer")]
        RandomBackgroundColorChanger = 20,
        [Display(Name = "Calorie Counter")]
        CalorieCounter = 21,
        [Display(Name = "Rock, Paper, Scissors Game")]
        RockPaperScissorsGame = 22,
        [Display(Name = "Music Player")]
        MusicPlayer = 23,
        [Display(Name = "Palindrome Checker")]
        PalindromeChecker = 24,
        [Display(Name = "Date Formatter")]
        DateFormatter = 25,
        [Display(Name = "Football Team Cards")]
        FootballTeamCards = 26,
        [Display(Name = "Todo App")]
        TodoApp = 27,
        [Display(Name = "Binary Converter")]
        BinaryConverter = 28,
        [Display(Name = "Roman Numeral Converter")]
        RomanNumeralConverter = 29,
        [Display(Name = "Spam Filter")]
        SpamFilter = 30,
        [Display(Name = "Number Sorter")]
        NumberSorter = 31,
        [Display(Name = "Statistics Calculator")]
        StatisticsCalculator = 32,
        [Display(Name = "Spreadsheet")]
        Spreadsheet = 33,
        [Display(Name = "TelephoneNumberValidator")]
        TelephoneNumberValidator = 34,
        [Display(Name = "ShoppingCart")]
        ShoppingCart = 35,
        [Display(Name = "PlatformerGame")]
        PlatformerGame = 36,
        [Display(Name = "DiceGame")]
        DiceGame = 37,
        [Display(Name = "CashRegister")]
        CashRegister = 38,
        [Display(Name = "Authors")]
        Authors = 39,
        [Display(Name = "ForumLeaderboard")]
        ForumLeaderboard = 41,
        [Display(Name = "SearchApp")]
        SearchApp = 42,

        #endregion

        #region Front End Development Libraries
        [Display(Name = "BootstrapFluidContainers")]
        BootstrapFluidContainers = 43,
        [Display(Name = "BootstrapCreateCustomHeading")]
        BootstrapCreateCustomHeading = 44,

        #endregion
    }
}
