using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Models;

namespace TrackHealthAndFitness.Repositories
{
    public interface IDifferentExerciseRepository
    {
        Task Add(DifferentExercise exercise);
        Task Remove(DifferentExercise exercise);
        Task Update(DifferentExercise exercise);
        Task DeleteTable();
        List<DifferentExercise> GetExercisesFromGroup(DifferentExercise.MuscleGroups muscleGroups);
    }
}
