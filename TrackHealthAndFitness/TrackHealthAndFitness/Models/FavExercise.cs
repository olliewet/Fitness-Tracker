using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;
using static TrackHealthAndFitness.Models.DifferentExercise;

namespace TrackHealthAndFitness.Models
{
    public class FavExercise
    {
        [Key]
        public int Id { get; set; }
        public string UserID { get; set; }
        public DayOfWeek Date { get; set; }
        public MuscleGroups TypeOfExercise { get; set; }
        public string ExerciseName { get; set; }
    }
}
