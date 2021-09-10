using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackHealthAndFitness.Models
{
    public class ExerciseValidation
    {
        //Used to check if exercise is the users Personal Best 
        public bool isPersonalBest(int inputWeight, int exerciseWeight)
        {
            if(inputWeight > exerciseWeight)
            {
                return true;
            }
            return false;
        }
    }
}
