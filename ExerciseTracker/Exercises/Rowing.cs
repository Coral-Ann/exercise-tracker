using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Rowing : AerobicsExercise
    {
        public override string Report()
        {
            return $"Rowing: {Distance}m, {Time} minutes, {Speed}kph";
        }
    }
}
