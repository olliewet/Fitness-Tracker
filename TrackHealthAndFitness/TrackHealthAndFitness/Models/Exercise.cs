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
        //Used to store a list of exercises from one day
        public List<ExerciseTracker> dayList { get; set; }
        public MuscleGroups TypeOfExercise { get; set; }
    }
}
