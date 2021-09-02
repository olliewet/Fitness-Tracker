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

        public async Task<IActionResult> ManageExecerise(string ExerciseName, DifferentExercise.MuscleGroups TypeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            Exercise exercise = new Exercise();
            exercise.ExerciseName = ExerciseName;
            exercise.TypeOfExercise = TypeOfExercise;
            exercise.exerciseTrackers = exerciseTrackerDB.GetExerciseHistory(user.Id, ExerciseName);

            // await GetAverage(ExerciseName);
            exercise.dayList = exercise.exerciseTrackers.FindAll(x => x.Date == DateTime.Today);
            //Sorts the Dates of the Exercises Into Oldest to Knewest
            //exercise.exerciseTrackers.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            exercise.exerciseTrackers.Sort((x, y) => y.Date.CompareTo(x.Date));
            return View(exercise);
        }

        //
        private string RemoveTime(string date)
        {
            // Remove a substring from the middle of the string.
            string toRemove = "00:00:00";
            string result = string.Empty;
            int i = date.IndexOf(toRemove);
            if (i >= 0)
            {
                result = date.Remove(i, toRemove.Length);
            }
            return result;
        }

        public async Task<IActionResult> HomeExercise(string date)
        {
            if (String.IsNullOrEmpty(date))
            {
                date = DateTime.Today.ToString();
            }

            string newDate = RemoveTime(date);
            DateTime datetime = DateTime.Parse(newDate);
            Exercise exercise = new Exercise();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            exercise.dayList = exerciseTrackerDB.GetExercisesFromDay(user.Id, datetime);
            exercise.trackedDate = datetime;
            return View(exercise);
        }

        public async Task<string> GetAverage(string ExerciseName)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            int counter = 0;
            int weightAverage = 0;
            int repAverage = 0;
            List<ExerciseTracker> listOfExercises = new List<ExerciseTracker>();
            listOfExercises = exerciseTrackerDB.GetExerciseHistory(user.Id, ExerciseName);
            foreach (ExerciseTracker item in listOfExercises)
            {
                counter++;
                weightAverage = weightAverage + item.Weight;
                repAverage = repAverage + item.Reps;
            }

            return "Average weight of :" + weightAverage / counter + " with the average reps of :" + repAverage / counter;
        }

        public IActionResult AddNewExecerise()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AddExecerise(ExerciseTracker.MuscleGroups muscle, string exerciseName, string Weight, string Reps)
        {
            DifferentExercise differentExercise = new DifferentExercise
            {
                ExerciseName = exerciseName,
                TypeOfExercise = (DifferentExercise.MuscleGroups)muscle
            };
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker exercise = exerciseTrackerDB.GetPersonalBestExercise(user.Id, exerciseName);
            bool personalbest = false;
            if (exercise != null)
            {
                //Very Basic to work out if personal best is true
                if (int.Parse(Weight) > exercise.Weight)
                {
                    personalbest = true;
                }

                exercise.PersonalBest = false;
                await exerciseTrackerDB.UpdateExercise(exercise);
            }
            else
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
            return RedirectToAction("ManageExecerise", "ExerciseManager", new { ExerciseName = differentExercise.ExerciseName, TypeOfExercise = differentExercise.TypeOfExercise });
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

        public async Task<IActionResult> DeleteExercise(DateTime date, string Id, string inputID, string ExerciseName, ExerciseTracker.MuscleGroups TypeOfExercise, int Reps, int Weight, bool PersonalBest)
        {
            DifferentExercise differentExercise = new DifferentExercise
            {
                ExerciseName = ExerciseName,
                TypeOfExercise = (DifferentExercise.MuscleGroups)TypeOfExercise
            };
            ExerciseTracker exercise = new ExerciseTracker
            {
                Date = date,
                ExerciseName = ExerciseName,
                Id = Id,
                InputID = inputID,
                PersonalBest = PersonalBest,
                Reps = Reps,
                TypeOfExercise = TypeOfExercise,
                Weight = Weight
            };
            await exerciseTrackerDB.RemoveExercise(exercise);

            return RedirectToAction("ManageExecerise", "ExerciseManager", new { ExerciseName = differentExercise.ExerciseName, TypeOfExercise = differentExercise.TypeOfExercise });
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