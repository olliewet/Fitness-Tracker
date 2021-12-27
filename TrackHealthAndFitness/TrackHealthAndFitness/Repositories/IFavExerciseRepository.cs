using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Repositories
{
    public interface IFavExerciseRepository
    {
        Task Add(FavExercise exercise);
        Task Remove(FavExercise exercise);
        Task Update(FavExercise exercise);
        Task DeleteTable();
        List<FavExercise> GetFavExercises(string userID, DayOfWeek day);
    }
}
