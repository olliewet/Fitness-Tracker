using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TrackHealthAndFitness.Models.DifferentExercise;

namespace TrackHealthAndFitness.Models
{
    public class Exercise
    {
        public string ExerciseName { get; set; }
        public List<ExerciseTracker> exerciseTrackers { get; set; }
        public MuscleGroups TypeOfExercise { get; set; }
    }
}
