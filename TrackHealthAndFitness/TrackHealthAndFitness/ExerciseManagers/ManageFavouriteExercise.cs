using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;
using TrackHealthAndFitness.Repositories;

namespace TrackHealthAndFitness.ExerciseManagers
{
    public class ManageFavouriteExercise
    {
        private readonly FavExerciseDBRepo favExerciseDB = null;
        public ManageFavouriteExercise(FavExerciseDBRepo favExercise)
        {
            favExerciseDB = favExercise;
        }
        public List<FavExercise> getFavExercises(DayOfWeek day, string UserID)
        {
            List<FavExercise> fav = favExerciseDB.GetFavExercises(UserID, day);
            return fav;
        }
    }
}
