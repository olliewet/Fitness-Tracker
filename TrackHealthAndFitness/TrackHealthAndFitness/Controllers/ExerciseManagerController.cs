using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Controllers
{
    public class ExerciseManagerController : Controller
    {
        private readonly ExerciseTrackerDBAccessLayer exerciseTrackerDB = null;
        private readonly DifferentExerciseDBAccessLayer differentExerciseDB = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ExerciseManagerController(ExerciseTrackerDBAccessLayer eDb, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, DifferentExerciseDBAccessLayer deDB)
        {
            exerciseTrackerDB = eDb;
            _signManager = signInManager;
            _userManager = userManager;
            differentExerciseDB = deDB;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageExecerise(DifferentExercise ExerciseModel)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker exercise = exerciseTrackerDB.GetPersonalBestExercise(user.Id, ExerciseModel.ExerciseName);
            //Pass In The Different Exercise 
            // Find the Personal Best for the passed in exercise 
            //Return an extrecise Tracker
            return View(exercise);
        }
        public IActionResult AddNewExecerise()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AddExecerise(ExerciseTracker.MuscleGroups muscle, string exerciseName, string Weight, string Reps)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker exercise = exerciseTrackerDB.GetPersonalBestExercise(user.Id, exerciseName);
            bool personalbest = false;
            //Very Basic to work out if personal best is true
            if (int.Parse(Weight) > exercise.Weight)
            {
                personalbest = true;
            }
            ExerciseTracker newExercise = new ExerciseTracker()
            {
                Id = user.Id,
                ExerciseName = exerciseName,
                TypeOfExercise = muscle,         
                Date = DateTime.Today,           
                PersonalBest = personalbest,
                Reps = int.Parse(Reps),
                Weight = int.Parse(Weight)
            };
            await exerciseTrackerDB.AddExercise(newExercise);
            return RedirectToAction("ManageExecerise", "ExerciseManager");
        }

        public async Task AddTypeOfExercise(DifferentExercise.MuscleGroups exerciseType, string exerciseName)
        {
            DifferentExercise differentExercise = new DifferentExercise()
            {
                ExerciseName = exerciseName,
                TypeOfExercise = exerciseType
            };
            await differentExerciseDB.AddExercise(differentExercise);
        }



        public async Task<IActionResult> SelectExercise(string ExerciseType)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            List<DifferentExercise> selectedExercises = new List<DifferentExercise>();
            //Needs Improving
            switch (ExerciseType)
            {
                case "Abs":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Abs);                
                    break;
                case "Back":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Back);
                    break;

                case "Biceps":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Biceps);
                    break;

                case "Cardio":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Cardio);
                    break;

                case "Chest":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Chest);
                    break;

                case "Legs":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Legs);
                    break;

                case "Shoulders":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Shoulders);
                    break;
                case "Triceps":
                    selectedExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Triceps);
                    break;
            }

            return View(selectedExercises);
        }
    }
}