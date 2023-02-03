using ExerciseTracker.Exercises;

namespace ExerciseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExercise[] exercisesCompleted = new IExercise[] {
                new Deadlift { Reps = 5, Sets = 2, Weight = 35 },
                new Jogging { Distance = 2, Time = 20, Speed = 10 },
                new Squat { Reps = 10, Sets = 4, Weight = 12 },
                new Rowing { Distance = 1000, Time = 6, Speed = 15 }
            };

            int overallDistance = 0;
            int overallWeight = 0;

            foreach (var exercise in exercisesCompleted)
            {
                Console.WriteLine(exercise.Report());

                if (exercise is AerobicsExercise aerobics)
                {
                    overallDistance += aerobics.Distance;
                }
                else if (exercise is WeightsExercise weights)
                {
                    overallWeight += weights.TotalLifted();
                }
            }

            Console.WriteLine($"Total distance of jogging and rowing: {overallDistance}");
            Console.WriteLine($"Total weight of squats and deadlifts: {overallWeight}");
            Console.ReadLine();

        }
    }
}