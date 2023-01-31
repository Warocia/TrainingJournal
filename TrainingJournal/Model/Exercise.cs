namespace TrainingJournal.Model
{
    public class Exercise
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;

        public Exercise(int id, string name)
        { 
            this.Id = id;
            this.Name = name;
        }
    }
}
