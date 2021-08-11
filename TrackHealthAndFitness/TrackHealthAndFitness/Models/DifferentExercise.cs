﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackHealthAndFitness.Data;

namespace TrackHealthAndFitness.Models
{
    [Keyless]
    public class DifferentExercise
    {
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

    public class DifferentExerciseDBAccessLayer
    {
        private readonly ApplicationDbContext _context = null; 
        public DifferentExerciseDBAccessLayer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddExercise(DifferentExercise exercise)
        {
            _context.DifferentExercises.Add(exercise);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Remove Exercise From Database 
        /// </summary>
        /// <param name="exercise"></param>
        public async void RemoveExercise(DifferentExercise exercise)
        {
            _context.DifferentExercises.Remove(exercise);
            await _context.SaveChangesAsync();
        }


        public async void DeleteTable()
        {
            var itemsToDelete = _context.Set<DifferentExercise>();
            _context.DifferentExercises.RemoveRange(itemsToDelete);
            await _context.SaveChangesAsync();
        }
        public async void UpdateExercise(DifferentExercise exercise)
        {
            _context.DifferentExercises.Update(exercise);
            await _context.SaveChangesAsync();
        }
        public List<DifferentExercise> GetExercisesFromGroup(string userID, DifferentExercise.MuscleGroups muscleGroups)
        {
            List<DifferentExercise> exercisesList = new List<DifferentExercise>();
            var data = _context.DifferentExercises.AsQueryable();
            data = data.Where(c => c.TypeOfExercise == muscleGroups);
            foreach (var item in data)
            {
                exercisesList.Add(item);
            }
            return exercisesList;
        }

    }
}