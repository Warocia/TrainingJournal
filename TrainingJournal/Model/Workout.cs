using System.ComponentModel.DataAnnotations;

namespace TrainingJournal.Model
{
    public class Workout
    {
        public Exercise Exercise { get; set; } 
        public decimal Weight { get; set; }
        public List<int> SetRepetition { get; set; }

        public Workout(Exercise exercise, decimal weight) 
        {
            this.Exercise = exercise;
            this.Weight = weight;
            this.SetRepetition = new List<int>();
        }

        public Workout()
        {
            this.SetRepetition = new List<int>();
        }
    }
}
