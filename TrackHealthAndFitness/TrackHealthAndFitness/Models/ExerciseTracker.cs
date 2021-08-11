using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;

namespace TrackHealthAndFitness.Models
{
    public class ExerciseTracker
    {
        public string Id { get; set; }
        public MuscleGroups TypeOfExercise { get; set; }
        public string ExerciseName { get; set; }
        public bool PersonalBest { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public DateTime Date { get; set; }

        public enum MuscleGroups
        {
            Abs,
            Back,
            Biceps, 
            Cardio, 
            Chest,
            Legs,
            Shoulders,
            Triceps
        }
    }

    public class ExerciseTrackerDBAccessLayer
    {
        private readonly ApplicationDbContext _context = null;

        public ExerciseTrackerDBAccessLayer(ApplicationDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Add Exercise To Database 
        /// </summary>
        /// <param name="exercise"></param>
        public async Task AddExercise(ExerciseTracker exercise)
        {
            _context.ExecriseTracker.Add(exercise);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove Exercise From Database 
        /// </summary>
        /// <param name="exercise"></param>
        public async void RemoveExercise(ExerciseTracker exercise)
        {         
            _context.ExecriseTracker.Remove(exercise);
            await _context.SaveChangesAsync();
        }


        public async void DeleteTable()
        {
            var itemsToDelete = _context.Set<ExerciseTracker>();
            _context.ExecriseTracker.RemoveRange(itemsToDelete);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Update Exercise 
        /// </summary>
        /// <param name="exercise"></param>
        public async void UpdateExercise(ExerciseTracker exercise)
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
            exercise = _context.ExecriseTracker.FirstOrDefault(c => c.Id == userID && c.ExerciseName == exerciseName && c.PersonalBest == true);
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






    }
}
