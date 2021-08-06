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
        public string TypeOfExercise { get; set; }
        public string ExerciseName { get; set; }
        public bool PersonalBest { get; set; }
        public int Weight { get; set; }
        public DateTime Date { get; set; }
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
        public async void AddExercise(ExerciseTracker exercise)
        {
            _context.ExecriseTracker.Add(exercise);
            await _context.SaveChangesAsync();
        }

        public async void RemoveExercise(ExerciseTracker exercise)
        {         
            _context.ExecriseTracker.Remove(exercise);
            await _context.SaveChangesAsync();
        }

        public async void UpdateExercise(ExerciseTracker exercise)
        {
            _context.ExecriseTracker.Update(exercise);
            await _context.SaveChangesAsync();
        }


        public ExerciseTracker GetPersonalBestExercise(string userID, string exerciseName)
        {
            ExerciseTracker exercise = new ExerciseTracker();
            exercise = _context.ExecriseTracker.FirstOrDefault(c => c.Id == userID && c.ExerciseName == exerciseName && c.PersonalBest == true);
            return exercise;
        }






    }
}
