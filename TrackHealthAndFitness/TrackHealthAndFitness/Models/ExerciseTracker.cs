using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;

namespace TrackHealthAndFitness.Models
{
    public class ExerciseTracker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string InputID { get; set; }
        public string Id { get; set; }
        public MuscleGroups TypeOfExercise { get; set; }
        public string ExerciseName { get; set; }
        public bool PersonalBest { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public DateTime Date { get; set; }

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
        public string Note { get; set; }
    }
}