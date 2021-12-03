using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Repositories
{
    public class DifferentExerciseDBRepo
    {
        private readonly ApplicationDbContext _context = null;

        public DifferentExerciseDBRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddExercise(DifferentExercise exercise)
        {
            try
            {
                bool newExercise = true;
                var data = _context.DifferentExercises.AsQueryable();
                data = data.Where(c => c.TypeOfExercise == exercise.TypeOfExercise);
                foreach (DifferentExercise item in data)
                {
                    if (item.ExerciseName == exercise.ExerciseName)
                    {
                        newExercise = false;
                        break;
                    }
                }

                if (newExercise == true)
                {
                    _context.DifferentExercises.Add(exercise);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {

            }
        }



        /// <summary>
        /// Remove Exercise From Database
        /// </summary>
        /// <param name="exercise"></param>
        public async Task RemoveExercise(DifferentExercise exercise)
        {
            try
            {
                _context.DifferentExercises.Remove(exercise);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
            }
        }

        public async void DeleteTable()
        {
            var itemsToDelete = _context.Set<DifferentExercise>();
            _context.DifferentExercises.RemoveRange(itemsToDelete);
            await _context.SaveChangesAsync();
        }

        public async void UpdateExercise(DifferentExercise exercise)
        {
            _context.DifferentExercises.Update(exercise);
            await _context.SaveChangesAsync();
        }

        public List<DifferentExercise> GetExercisesFromGroup(DifferentExercise.MuscleGroups muscleGroups)
        {
            List<DifferentExercise> exercisesList = new List<DifferentExercise>();
            var data = _context.DifferentExercises.AsQueryable();
            data = data.Where(c => c.TypeOfExercise == muscleGroups);
            foreach (var item in data)
            {
                exercisesList.Add(item);
            }
            return exercisesList;
        }
    }
}
