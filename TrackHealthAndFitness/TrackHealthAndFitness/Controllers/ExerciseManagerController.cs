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
        private readonly FavExerciseDBLayer favExerciseDB = null;
        private readonly DifferentExerciseDBAccessLayer differentExerciseDB = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ExerciseManagerController(ExerciseTrackerDBAccessLayer eDb, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, DifferentExerciseDBAccessLayer deDB, FavExerciseDBLayer favExercise)
        {
            exerciseTrackerDB = eDb;
            _signManager = signInManager;
            _userManager = userManager;
            differentExerciseDB = deDB;
            favExerciseDB = favExercise;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<List<FavExercise>> getFavExercises(DateTime date)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            List<FavExercise> fav = favExerciseDB.GetFavExercises(user.Id, date);
            return fav;
        }

        public async Task<IActionResult> ExerciseRoutine(string Date)
        {
            List<FavExercise> favExercises = await getFavExercises(DateTime.Parse(Date));
            return View(favExercises);
        }

        public async Task<IActionResult> ManageExecerise(string ExerciseName, DifferentExercise.MuscleGroups TypeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            Exercise exercise = new Exercise();
            ExerciseTracker personalBest = exerciseTrackerDB.GetPersonalBestExercise(user.Id, ExerciseName);
            exercise.ExerciseName = ExerciseName;
            exercise.TypeOfExercise = TypeOfExercise;
            exercise.exerciseTrackers = exerciseTrackerDB.GetExerciseHistory(user.Id, ExerciseName);

            // await GetAverage(ExerciseName);
            exercise.dayList = exercise.exerciseTrackers.FindAll(x => x.Date == DateTime.Today);
            //Sorts the Dates of the Exercises Into Oldest to Knewest
            //exercise.exerciseTrackers.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            exercise.exerciseTrackers.Sort((x, y) => y.Date.CompareTo(x.Date));
            exercise.OneRepMax = ExerciseValidation.OneRepMax(personalBest.Weight, personalBest.Reps);
            return View(exercise);
        }

        public async Task<IActionResult> PersonalBest(ExerciseTracker.MuscleGroups TypeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            List<ExerciseTracker> personalBestTracker = new List<ExerciseTracker>();
            personalBestTracker = exerciseTrackerDB.GetExercisePersonalBestHistory(user.Id, TypeOfExercise);
            return View(personalBestTracker);
        }

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
            await addToRoutine(DateTime.Today,"Bench",DifferentExercise.MuscleGroups.Chest);
            //await getFavExercises();
            if (String.IsNullOrEmpty(date))
            {
                date = DateTime.Today.ToString();
            }

            ExerciseValidation exerciseValidation = new ExerciseValidation();
            ExerciseTracker personalBestExercise = new ExerciseTracker();
            string newDate = RemoveTime(date);
            DateTime datetime = DateTime.Parse(newDate);
            Exercise exercise = new Exercise();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            exercise.dayList = exerciseTrackerDB.GetExercisesFromDay(user.Id, datetime);

            //Works But Needs Changing 
            personalBestExercise = exerciseTrackerDB.GetPersonalBestExercise(user.Id, "Leg Press");
           
            if (exercise.dayList != null)
            {
                exercise.OneRepMax = ExerciseValidation.OneRepMax(personalBestExercise.Weight, personalBestExercise.Reps);
            }
            exercise.trackedDate = datetime;
      
            return View(exercise);
        }

        //Used to get the average of a set
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

        //Adding the set of the exercise 
        [Authorize]
        public async Task<IActionResult> AddExecerise(ExerciseTracker.MuscleGroups muscle, string exerciseName, string Weight, string Reps)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            DifferentExercise differentExercise = new DifferentExercise
            {
                ExerciseName = exerciseName,
                TypeOfExercise = (DifferentExercise.MuscleGroups)muscle
            };

            ExerciseTracker exercise = exerciseTrackerDB.GetPersonalBestExercise(user.Id, exerciseName);
            bool personalbest = false;
           
            if (exercise != null)
            {
                bool tempBest = false;
                tempBest = ExerciseValidation.isPersonalBest(int.Parse(Weight), exercise.Weight);
                exercise.PersonalBest = !tempBest;
                personalbest = tempBest;
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

        //adding the type of exercise 
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


        public async Task addToRoutine(DateTime dateTime, string ExerciseName, DifferentExercise.MuscleGroups typeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            FavExercise favExercise = new FavExercise
            {
                Date = dateTime,
                ExerciseName = ExerciseName,
                TypeOfExercise = typeOfExercise,
                UserID = user.Id
            };
            await favExerciseDB.AddFavExercise(favExercise);
        }

     


        public async Task<IActionResult> SelectExercise(string ExerciseType)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseDetail selectedExerciseType = new ExerciseDetail();
            //Needs Improving
            switch (ExerciseType)
            {
                case "Abs":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Abs);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Abs;
                    break;

                case "Back":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Back);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Back;
                    break;

                case "Biceps":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Biceps);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Biceps;
                    break;

                case "Cardio":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Cardio);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Cardio;
                    break;

                case "Chest":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Chest);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Chest;
                    break;

                case "Legs":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Legs);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Legs;
                    break;

                case "Shoulders":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Shoulders);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Shoulders;
                    break;

                case "Triceps":
                    selectedExerciseType.differentExercises = differentExerciseDB.GetExercisesFromGroup(DifferentExercise.MuscleGroups.Triceps);
                    selectedExerciseType.TypeOfExercise = ExerciseTracker.MuscleGroups.Triceps;
                    break;
            }

            return View(selectedExerciseType);
        }
    }
}