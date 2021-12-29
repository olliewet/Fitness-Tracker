using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackHealthAndFitness.Models
{
    public class ExerciseValidation
    {
        //Used to check if exercise is the users Personal Best 
        public static bool isPersonalBest(int inputWeight, int exerciseWeight)
        {
            if(inputWeight > exerciseWeight)
            {
                return true;
            }
            return false;
        }

        public static double OneRepMax(float Weight, float Reps)
        {
            double t = 0.0333;
            double answer = Weight * Reps * t;
            return answer + Weight;
        }

        public static string ReturnAverageWeight(List<ExerciseTracker> ExerciseList)
        {
            if(!ExerciseList.Any())
            {
                return "Invalid Data";
            }

            int counter = 0, weightAverage = 0, repAverage = 0;
            foreach (ExerciseTracker item in ExerciseList)
            {
                counter++;
                weightAverage = weightAverage + item.Weight;
                repAverage = repAverage + item.Reps;
            }

            return "Average weight of :" + weightAverage / counter + " with the average reps of :" + repAverage / counter;
   
        }
    }
}
