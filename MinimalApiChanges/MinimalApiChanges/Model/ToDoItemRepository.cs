namespace MinimalApiChanges.Model
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private static List<ToDoItem>? _allToDoItems;

        public List<ToDoItem>? GetAllToDoItems()
        {
            if (_allToDoItems == null)
            {
                InitializeData();
            }

            return _allToDoItems;
        }

        public void AddToDoItem(ToDoItem toDoItem)
        {
            _allToDoItems?.Add(toDoItem);
        }

        private void InitializeData()
        {
            _allToDoItems = new List<ToDoItem>()
                {
                    new ToDoItem(){Title = "Get milk", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Completed=true },
                    new ToDoItem(){Title = "Learn Blazor", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                    new ToDoItem(){Title = "Create an app with Blazor", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Completed=true},
                    new ToDoItem(){Title = "Put up Christmas tree", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit."}
                };
        }
    }
}
