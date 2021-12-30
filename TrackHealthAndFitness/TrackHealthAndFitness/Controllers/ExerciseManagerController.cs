using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using TrackHealthAndFitness.Helpers;
using TrackHealthAndFitness.Models;
using TrackHealthAndFitness.Repositories;
using static TrackHealthAndFitness.Models.DifferentExercise;

namespace TrackHealthAndFitness.Controllers
{
    public class ExerciseManagerController : Controller
    {
        private readonly IExerciseTrackerRepository exerciseTrackerDB = null;
        private readonly IFavExerciseRepository favExerciseDB = null;
        private readonly IDifferentExerciseRepository differentExerciseDB = null;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ExerciseManagerController(IExerciseTrackerRepository eDb, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IDifferentExerciseRepository deDB, IFavExerciseRepository favExercise)
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

        #region Exercise Routine 

        public async Task<IActionResult> ExerciseRoutine(int Date)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            DayOfWeek dayofWeek = DateHelper.intToDay(Date);         
            return View(favExerciseDB.GetFavExercises(user.Id,dayofWeek));
        }

        public async Task<IActionResult> AddExerciseRoutine(int Date, string _ExerciseName, MuscleGroups _TypeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            DayOfWeek dayofWeek = DateHelper.intToDay(Date);
           
            FavExercise fav = new FavExercise
            {
                ExerciseName = _ExerciseName,
                Date = dayofWeek,
                UserID = user.Id,
                TypeOfExercise = _TypeOfExercise                       
            };
            await favExerciseDB.Add(fav);
            return RedirectToAction("ExerciseRoutine", new { Date = 1 });
        }

        public async Task<IActionResult> removeFromRoutine(int Id, DayOfWeek day, string ExerciseName, DifferentExercise.MuscleGroups typeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            FavExercise favExercise = new FavExercise
            {
                Id = Id,
                Date = day,
                ExerciseName = ExerciseName,
                TypeOfExercise = typeOfExercise,
                UserID = user.Id
            };
            await favExerciseDB.Remove(favExercise);
            return RedirectToAction("ExerciseRoutine", new { Date = 1 });
        }
        #endregion

        #region Manage Exercise 
        public async Task<IActionResult> ManageExecerise(string ExerciseName, DifferentExercise.MuscleGroups TypeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker personalBest = exerciseTrackerDB.GetPersonalBestExercise(user.Id, ExerciseName);
            Exercise exercise = new Exercise()
            {
                ExerciseName = ExerciseName,
                TypeOfExercise = TypeOfExercise,
                exerciseTrackers = exerciseTrackerDB.GetExerciseHistory(user.Id, ExerciseName),
                dayList = exerciseTrackerDB.GetExerciseHistory(user.Id, ExerciseName).FindAll(x => x.Date == DateTime.Today),
                OneRepMax = ExerciseValidation.OneRepMax(personalBest.Weight, personalBest.Reps)
            };
            exercise.exerciseTrackers.Sort((x, y) => y.Date.CompareTo(x.Date));
            return View(exercise);
        }
        #endregion

        #region Personal Best 

        public async Task<IActionResult> PersonalBest(ExerciseTracker.MuscleGroups TypeOfExercise)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            List<ExerciseTracker> personalBestTracker = exerciseTrackerDB.GetExercisePersonalBestHistory(user.Id, TypeOfExercise);
            return View(personalBestTracker);
        }

        #endregion

        #region Home Exercise 

        public async Task<IActionResult> HomeExercise(string date)
        {
            if (String.IsNullOrEmpty(date))
            {
                date = DateTime.Today.ToString();
            }
           
            var user = await _userManager.GetUserAsync(HttpContext.User);
            DateTime datetime = DateTime.Parse(DateHelper.RemoveTime(date));
            var dayList = exerciseTrackerDB.GetExercisesFromDay(user.Id, datetime);
            Exercise exercise = new Exercise();
            if (dayList != null)
            {
                exercise = new Exercise()
                {
                    dayList = dayList,
                    trackedDate = datetime
                };
            }
                  
            return View(exercise);
        }
        #endregion

        #region Get Average 
        public async Task<string> GetAverage(string ExerciseName)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return ExerciseValidation.ReturnAverageWeight(exerciseTrackerDB.GetExerciseHistory(user.Id, ExerciseName));    
        }
        #endregion

        #region Add New Exercise 
        public IActionResult AddNewExecerise()
        {
            return View();
        }

        
        [Authorize]
        public async Task<IActionResult> AddExecerise(ExerciseTracker.MuscleGroups muscle, string exerciseName, string Weight, string Reps)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            ExerciseTracker exercise = exerciseTrackerDB.GetPersonalBestExercise(user.Id, exerciseName);
            //Personal Best Does Not incorporate reps 
            bool personalbest = false;
            if (exercise != null)
            {          
                personalbest = ExerciseValidation.isPersonalBest(int.Parse(Weight), exercise.Weight);
                exercise.PersonalBest = !personalbest;
                await exerciseTrackerDB.Update(exercise);
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
            await exerciseTrackerDB.Add(newExercise);
            return RedirectToAction("ManageExecerise", "ExerciseManager", new { ExerciseName = exerciseName, TypeOfExercise = muscle });
        }

        #endregion

        #region Add Type Of Exercise 
        public async Task AddTypeOfExercise(DifferentExercise.MuscleGroups exerciseType, string exerciseName)
        {
            DifferentExercise differentExercise = new DifferentExercise()
            {
                ExerciseName = exerciseName,
                TypeOfExercise = exerciseType
            };
            await differentExerciseDB.Add(differentExercise);
        }
        #endregion

        #region Delete Exercise 
        public async Task<IActionResult> DeleteExercise(DateTime date, string Id, string inputID, string ExerciseName, ExerciseTracker.MuscleGroups TypeOfExercise, int Reps, int Weight, bool PersonalBest)
        {
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
            await exerciseTrackerDB.Remove(exercise);
            return RedirectToAction("ManageExecerise", "ExerciseManager", new { ExerciseName = ExerciseName, TypeOfExercise = TypeOfExercise });
        }
        #endregion

        #region Select Exercise 
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
        #endregion
    }
}