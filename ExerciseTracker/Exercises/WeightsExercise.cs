namespace ExerciseTracker.Exercises
{
    public abstract class WeightsExercise : IExercise
    {
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }

        public int TotalLifted()
        {
            return (Weight * Reps) * Sets;
        }

        public abstract string Report();

    }
}