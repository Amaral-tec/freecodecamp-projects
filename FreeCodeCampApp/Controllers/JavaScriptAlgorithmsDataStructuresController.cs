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
                _ => Json(new { error = true, mensagem = "Project not found!" }),
            };
        }
    }
}
