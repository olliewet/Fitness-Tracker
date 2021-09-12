using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TrackHealthAndFitness.Models.ExerciseTracker;

namespace TrackHealthAndFitness.Models
{
    public class ExerciseDetail
    {
        //Used to Store the Type Of Exercise and a list of the exercises for that type
        public MuscleGroups TypeOfExercise { get; set; }
        public List<DifferentExercise> differentExercises { get; set; }
    }
}
