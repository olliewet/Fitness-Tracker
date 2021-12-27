using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Repositories
{
    public class ExerciseTrackerDBRepo:IExerciseTrackerRepository
    {
        private readonly ApplicationDbContext _context = null;

        public ExerciseTrackerDBRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Add Exercise To Database
        /// </summary>
        /// <param name="exercise"></param>
        public async Task Add(ExerciseTracker exercise)
        {
            try
            {
                _context.ExecriseTracker.Add(exercise);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// Remove Exercise From Database
        /// </summary>
        /// <param name="exercise"></param>
        public async Task Remove(ExerciseTracker exercise)
        {
            try
            {
                _context.ExecriseTracker.Remove(exercise);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }

        public async Task DeleteTable()
        {
            var itemsToDelete = _context.Set<ExerciseTracker>();
            _context.ExecriseTracker.RemoveRange(itemsToDelete);
            await _context.SaveChangesAsync();
        }


        /// <summary>
        /// Update Exercise
        /// </summary>
        /// <param name="exercise"></param>
        public async Task Update(ExerciseTracker exercise)
        {
            _context.ExecriseTracker.Update(exercise);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get Users Perosnal Best For Exercise
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="exerciseName"></param>
        /// <returns></returns>
        public ExerciseTracker GetPersonalBestExercise(string userID, string exerciseName)
        {
            ExerciseTracker exercise = new ExerciseTracker();
            try
            {
                List<ExerciseTracker> exercisesList = new List<ExerciseTracker>();
                var exercises = _context.ExecriseTracker; // define query
                                                          //Way too inefficent because it loads all exercises 
                foreach (var e in exercises) // query executed and data obtained from database
                {
                    if (e.PersonalBest == true && e.Id == userID && e.ExerciseName == exerciseName && e.PersonalBest == true)
                    {
                        exercise = e;
                    }
                }
                return exercise;
            }
            catch (Exception E)
            {

            }
            return exercise;
        }

        public List<ExerciseTracker> GetExercisesFromGroup(string userID, ExerciseTracker.MuscleGroups muscleGroups)
        {
            List<ExerciseTracker> exercisesList = new List<ExerciseTracker>();
            var data = _context.ExecriseTracker.AsQueryable();
            data = data.Where(c => c.Id == userID && c.TypeOfExercise == muscleGroups && c.PersonalBest == true);
            foreach (var item in data)
            {
                exercisesList.Add(item);
            }
            return exercisesList;
        }

        public List<ExerciseTracker> GetExerciseHistory(string userID, string exerciseName)
        {
            List<ExerciseTracker> exercisesList = new List<ExerciseTracker>();
            var exercises = _context.ExecriseTracker; // define query
            foreach (var e in exercises) // query executed and data obtained from database
            {
                if (e.ExerciseName == exerciseName && e.Id == userID)
                {
                    exercisesList.Add(e);
                }
            }
            return exercisesList;
        }

        public List<ExerciseTracker> GetExercisePersonalBestHistory(string userID, ExerciseTracker.MuscleGroups muscleGroups)
        {
            List<ExerciseTracker> exercisesList = new List<ExerciseTracker>();
            var exercises = _context.ExecriseTracker; // define query
            //Way too inefficent because it loads all exercises 
            foreach (var e in exercises) // query executed and data obtained from database
            {
                if (e.PersonalBest == true && e.Id == userID && e.TypeOfExercise == muscleGroups)
                {
                    exercisesList.Add(e);
                }
            }
            return exercisesList;
        }


        public List<ExerciseTracker> GetExercisesFromDay(string userID, DateTime date)
        {
            List<ExerciseTracker> exercisesList = new List<ExerciseTracker>();

            var exercises = _context.ExecriseTracker; // define query

            //Looping through the whole database, not efficent 
            foreach (var e in exercises) // query executed and data obtained from database
            {
                if (e.Date == date && e.Id == userID)
                {
                    exercisesList.Add(e);
                }
            }
            return exercisesList;
        }
    }
}
