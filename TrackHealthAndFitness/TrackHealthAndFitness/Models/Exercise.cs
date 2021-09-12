using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TrackHealthAndFitness.Models.DifferentExercise;

namespace TrackHealthAndFitness.Models
{
    public class Exercise
    {
        //Example of use of the model would be squat, the list is used to store the list of sets, tracked date
        public string ExerciseName { get; set; }
        public List<ExerciseTracker> exerciseTrackers { get; set; }
        //Used to store a list of exercises from one day
        public List<ExerciseTracker> dayList { get; set; }
        public DateTime trackedDate { get; set; }
        public MuscleGroups TypeOfExercise { get; set; }
    }
}
