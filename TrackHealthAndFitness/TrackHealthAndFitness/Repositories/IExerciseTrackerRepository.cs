using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Repositories
{
    public interface IExerciseTrackerRepository
    {
        Task Add(ExerciseTracker exercise);
        Task Remove(ExerciseTracker exercise);
        Task Update(ExerciseTracker exercise);
        Task DeleteTable();
        ExerciseTracker GetPersonalBestExercise(string userID, string exerciseName);
        List<ExerciseTracker> GetExerciseHistory(string userID, string exerciseName);
        List<ExerciseTracker> GetExercisesFromDay(string userID, DateTime date);
        List<ExerciseTracker> GetExercisePersonalBestHistory(string userID, ExerciseTracker.MuscleGroups muscleGroups);
    }
}
