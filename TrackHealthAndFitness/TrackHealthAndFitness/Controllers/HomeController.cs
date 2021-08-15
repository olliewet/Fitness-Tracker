using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExerciseTrackerDBAccessLayer exerciseTrackerDB = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(ILogger<HomeController> logger, ExerciseTrackerDBAccessLayer eDb, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            exerciseTrackerDB = eDb;
            _logger = logger;
            _signManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> FitnessTrackerAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Legs);
            ExerciseTracker exercise =  exerciseTrackerDB.GetPersonalBestExercise(user.Id, "Squat");
            return View();
        }

        public async Task<ExerciseTracker> AddDatabaseTest()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker exercise = new ExerciseTracker()
            {
                Id = user.Id,
                Date = DateTime.Now,
                ExerciseName = "Squat",
                Weight = 400,
                PersonalBest = true,
                TypeOfExercise = ExerciseTracker.MuscleGroups.Legs
            };
            return exercise;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
