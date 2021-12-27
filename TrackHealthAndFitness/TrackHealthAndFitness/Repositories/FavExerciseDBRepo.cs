using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Repositories
{
    public class FavExerciseDBRepo: IFavExerciseRepository
    {
        private readonly ApplicationDbContext _context = null;
        public FavExerciseDBRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(FavExercise exercise)
        {
            try
            {
                _context.FavExercises.Add(exercise);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }
        public async Task Remove(FavExercise exercise)
        {
            try
            {
                _context.FavExercises.Remove(exercise);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
        }

        public async Task DeleteTable()
        {
            var itemsToDelete = _context.Set<FavExercise>();
            _context.FavExercises.RemoveRange(itemsToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(FavExercise exercise)
        {
            _context.FavExercises.Update(exercise);
            await _context.SaveChangesAsync();
        }

        public List<FavExercise> GetFavExercises(string userID, DayOfWeek day)
        {
            List<FavExercise> favExercisesList = new List<FavExercise>();
            var data = _context.FavExercises.AsQueryable();
            data = data.Where(c => c.UserID == userID && c.Date == day);
            foreach (var item in data)
            {
                favExercisesList.Add(item);
            }
            return favExercisesList;
        }
    }
}
