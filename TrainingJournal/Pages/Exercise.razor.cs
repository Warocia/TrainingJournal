using Microsoft.JSInterop;

namespace TrainingJournal.Pages
{
    public partial class Exercise
    {
        private List<TrainingJournal.Model.Workout>? workouts;

        private List<TrainingJournal.Model.Exercise> exercises = new List<Model.Exercise>() { new Model.Exercise(1, "Maastaveto"),
                new Model.Exercise(2, "Kyykky"),  new Model.Exercise(3, "Leuanveto")};

        private void AddNewWorkout()
        {
            if (workouts == null)
            {
                workouts = new List<Model.Workout>();
            }

            TrainingJournal.Model.Workout newItem = new Model.Workout(null, 0);
            workouts.Add(newItem);
        }

        async Task AddReps(TrainingJournal.Model.Workout workout)
        {
            string prompted = await JsRuntime.InvokeAsync<string>("prompt", "Toistoja"); // Prompt
            workout.SetRepetition.Add(int.Parse(prompted));
        }

        async Task RemoveWorkout(TrainingJournal.Model.Workout removeThis)
        {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Haluatko varmasti poistaa rivin?");
            if (confirmed && workouts != null)
            {
                workouts.Remove(removeThis);
            }
        }

        async Task <IEnumerable<Model.Exercise>> FilterExercise(string searchText)
        {
            return await Task.FromResult(exercises.Where(x => x.Name.ToLower().Contains(searchText.ToLower())).ToList());
        }
    }
}
