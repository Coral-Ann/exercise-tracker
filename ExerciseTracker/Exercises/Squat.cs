﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Squat : WeightsExercise
    {
        public override string Report()
        {
            return $"Squats: {Reps} reps, {Sets} sets, {Weight}kg";
        }
    }
}
