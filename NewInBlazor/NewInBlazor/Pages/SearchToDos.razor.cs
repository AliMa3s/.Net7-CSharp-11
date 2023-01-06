using NewInBlazor.Model;

namespace NewInBlazor.Pages
{
    public partial class SearchToDos
    {
        public List<ToDoItem> AllToDoItems { get; set; } = new List<ToDoItem>();
        public bool Loading { get; set; }
        private string? searchText;
        private List<ToDoItem> FilteredItems = new List<ToDoItem>();

        private async Task PerformSearch()
        {
            FilteredItems = AllToDoItems.Where(t => t.Title.Contains(searchText, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        protected override void OnInitialized()
        {
            Loading = true;

            AllToDoItems = new List<ToDoItem>()
            {
                new ToDoItem(){Title = "Get milk", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new ToDoItem(){Title = "Learn Blazor", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new ToDoItem(){Title = "Create an app with Blazor", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit."},
                new ToDoItem(){Title = "Put up Christmas tree", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit."}
            };

            Loading = false;
        }

    }
}
