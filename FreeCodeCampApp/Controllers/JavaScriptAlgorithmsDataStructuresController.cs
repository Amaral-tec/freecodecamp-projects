﻿using FreeCodeCampApp.Models.Enums;
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
                Projects.CalorieCounter => PartialView("_CalorieCounter"),
                Projects.RockPaperScissorsGame => PartialView("_RockPaperScissorsGame"),
                Projects.MusicPlayer => PartialView("_MusicPlayer"),
                Projects.PalindromeChecker => PartialView("_PalindromeChecker"),
                Projects.DateFormatter => PartialView("_DateFormatter"),
                Projects.FootballTeamCards => PartialView("_FootballTeamCards"),
                Projects.TodoApp => PartialView("_TodoApp"),
                Projects.BinaryConverter => PartialView("_BinaryConverter"),
                Projects.RomanNumeralConverter => PartialView("_RomanNumeralConverter"),
                Projects.SpamFilter => PartialView("_SpamFilter"),
                Projects.NumberSorter => PartialView("_NumberSorter"),
                Projects.StatisticsCalculator => PartialView("_StatisticsCalculator"),
                Projects.Spreadsheet => PartialView("_Spreadsheet"),
                Projects.TelephoneNumberValidator => PartialView("_TelephoneNumberValidator"),
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
