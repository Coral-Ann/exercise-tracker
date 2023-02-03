namespace ExerciseTracker.Exercises
{
    public abstract class AerobicsExercise : IExercise
    {
        public int Distance { get; set; }
        public int Time { get; set; }
        public int Speed { get; set; }

        public abstract string Report();
    }
}