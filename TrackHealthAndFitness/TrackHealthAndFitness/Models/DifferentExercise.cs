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
       
        /// <summary>
        /// DifferentExercise is used to store the different exercises into the database, for example a type of exercise would be a squat
        /// A different exercise consists of a name and a type, a type describes what muscle group the exercise belongs too 
        /// </summary>

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