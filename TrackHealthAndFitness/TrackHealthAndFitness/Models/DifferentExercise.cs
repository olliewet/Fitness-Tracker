using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;

namespace TrackHealthAndFitness.Models
{
    public class DifferentExercise
    {
        [Key]
        public string ExerciseName { get; set; }

        public MuscleGroups TypeOfExercise { get; set; }

        public enum MuscleGroups
        {
            Abs,
            Back,
            Biceps,
            Cardio,
            Chest,
            Legs,
            Shoulders,
            Triceps
        }
    }
}