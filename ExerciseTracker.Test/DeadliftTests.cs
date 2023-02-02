using ExerciseTracker.Exercises;

namespace ExerciseTracker.Test
{
    public class DeadliftTests
    {
        [Test]
        public void DeadliftReportsRepsSetsAndWeight()
        {
            var deadlift = new Deadlift
            {
                Reps = 5,
                Sets = 3,
                Weight = 35
            };

            Assert.That(deadlift.Report(), Is.EqualTo("Deadlift: 5 reps, 3 sets, 35kg"));
        }

        [Test]
        public void DeadliftCalculatesTotalWeightLifted()
        {
            var deadlift = new Deadlift
            {
                Reps = 8,
                Sets = 3,
                Weight = 12
            };

            Assert.That(deadlift.TotalLifted(), Is.EqualTo(288));
        }
    }
}