using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Controllers
{
    public class ExerciseManagerController : Controller
    {
        private readonly ExerciseTrackerDBAccessLayer exerciseTrackerDB = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public ExerciseManagerController(ExerciseTrackerDBAccessLayer eDb, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            exerciseTrackerDB = eDb;
            _signManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SelectExercise(string ExerciseType)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            List<ExerciseTracker> selectedExercises = new List<ExerciseTracker>();
            //Needs Improving 
            switch (ExerciseType)
            {
                case "Abs":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Abs);
                    break;
                case "Back":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Back);
                    break;
                case "Biceps":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Biceps);
                    break;
                case "Cardio":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Cardio);
                    break;
                case "Chest":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Chest);
                    break;
                case "Legs":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Legs);
                    break;
                case "Shoulders":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Shoulders);
                    break;
                case "Triceps":
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Triceps);
                    break;
                    
            }
          
            return View(selectedExercises);
        }
    }
}
