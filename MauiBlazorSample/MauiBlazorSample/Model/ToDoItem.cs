namespace MauiBlazorSample.Model
{
    public class ToDoItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }
        public DateOnly DateCompleted { get; set; }
        public bool Completed { get; set; }

    }
}
