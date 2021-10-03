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
    }
}
