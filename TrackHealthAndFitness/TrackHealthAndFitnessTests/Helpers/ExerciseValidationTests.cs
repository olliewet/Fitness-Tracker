using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackHealthAndFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackHealthAndFitness.Models.Tests
{
    [TestClass()]
    public class ExerciseValidationTests
    {
        ExerciseTracker exercise1;
        ExerciseTracker exercise2;
        ExerciseTracker exercise3;
        public ExerciseValidationTests()
        {
            exercise1 = new ExerciseTracker
            {
                Id = "be3e25ba-6eaf-4ab5-852a-17a9e43511e7",
                TypeOfExercise = ExerciseTracker.MuscleGroups.Legs,
                ExerciseName = "Squat",
                PersonalBest = false,
                Weight = 45,
                Reps = 5,
                Date = DateTime.Today
            };
             exercise2 = new ExerciseTracker
            {
                Id = "be3e25ba-6eaf-4ab5-852a-17a9e43511e7",
                TypeOfExercise = ExerciseTracker.MuscleGroups.Legs,
                ExerciseName = "Squat",
                PersonalBest = false,
                Weight = 45,
                Reps = 5,
                Date = DateTime.Today
            };
             exercise3 = new ExerciseTracker
            {
                Id = "be3e25ba-6eaf-4ab5-852a-17a9e43511e7",
                TypeOfExercise = ExerciseTracker.MuscleGroups.Legs,
                ExerciseName = "Squat",
                PersonalBest = false,
                Weight = 45,
                Reps = 5,
                Date = DateTime.Today
            };

        }
        [TestMethod()]
        public void NotPersonalBestTest()
        {
            Assert.AreEqual(ExerciseValidation.isPersonalBest(100, 200), false);
        }
        [TestMethod()]
        public void IsPersonalBestTest()
        {
            Assert.AreEqual(ExerciseValidation.isPersonalBest(201, 200), true);
        }
        [TestMethod()]
        public void PersonalBestSameValueTest()
        {
            Assert.AreEqual(ExerciseValidation.isPersonalBest(200, 200), false);
        }

        [TestMethod()]
        public void OneRepMax100Kg()
        {
            Assert.AreEqual(133.7, ExerciseValidation.OneRepMax(100, 10));
        }

        [TestMethod()]
        public void ReturnAverageWeightTest()
        {
    
            List<ExerciseTracker> listOfExercises = new List<ExerciseTracker>();
            listOfExercises.Add(exercise1);
            listOfExercises.Add(exercise2);
            listOfExercises.Add(exercise3);           
            Assert.AreEqual("Average weight of :45 with the average reps of :5", ExerciseValidation.ReturnAverageWeight(listOfExercises));
        }
        [TestMethod()]
        public void ReturnAverageWeightInvalidTest()
        {
            List<ExerciseTracker> listOfExercises = new List<ExerciseTracker>();
        
            Assert.AreEqual("Invalid Data", ExerciseValidation.ReturnAverageWeight(listOfExercises));
        }
    }
}