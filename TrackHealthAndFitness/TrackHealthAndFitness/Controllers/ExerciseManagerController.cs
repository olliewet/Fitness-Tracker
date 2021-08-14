﻿using Microsoft.AspNetCore.Authorization;
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

        public IActionResult ManageExecerise(ExerciseTracker ExerciseModel)
        {
            return View(ExerciseModel);
        }
        public IActionResult AddNewExecerise()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AddExecerise(ExerciseTracker.MuscleGroups muscle, string exerciseName, string Weight, string Reps)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker newExercise = new ExerciseTracker()
            {
                Id = user.Id,
                ExerciseName = exerciseName,
                TypeOfExercise = muscle,         
                Date = DateTime.Today,
                //Add The Logic To Check if personal best is true
                PersonalBest = true,
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
            List<ExerciseTracker> selectedExercises = new List<ExerciseTracker>();
            //Needs Improving
            switch (ExerciseType)
            {
                case "Abs":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Abs);
                    break;

                case "Back":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Back);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Back);
                    break;

                case "Biceps":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Biceps);
                    break;

                case "Cardio":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Cardio);
                    break;

                case "Chest":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Chest);
                    break;

                case "Legs":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Legs);
                    break;

                case "Shoulders":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Shoulders);
                    break;

                case "Triceps":
                    //selectedExercises = differentExerciseDB.GetExercisesFromGroup(user.Id, DifferentExercise.MuscleGroups.Abs);
                    selectedExercises = exerciseTrackerDB.GetExercisesFromGroup(user.Id, ExerciseTracker.MuscleGroups.Triceps);
                    break;
            }

            return View(selectedExercises);
        }
    }
}