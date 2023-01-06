using Microsoft.AspNetCore.Components.QuickGrid;
using NewInBlazor.Model;

namespace NewInBlazor.Pages
{
    public partial class ToDoHistory
    {
        public IQueryable<ToDoItem> AllToDoItems { get; set; } = new List<ToDoItem>().AsQueryable();
        public bool Loading { get; set; }

        PaginationState pagination = new PaginationState { ItemsPerPage = 3 };
        private string titleFilter = string.Empty;

        IQueryable<ToDoItem> FilteredItems => AllToDoItems.Where(x => x.Title.Contains(titleFilter, StringComparison.CurrentCultureIgnoreCase));

        protected override void OnInitialized()
        {
            Loading = true;

            AllToDoItems = (new List<ToDoItem>()
            {
                new ToDoItem(){Title = "Get milk", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", DateCompleted =  DateOnly.FromDateTime(DateTime.Now.AddDays(-1))},
                new ToDoItem(){Title = "Learn Blazor", Description="Phasellus imperdiet libero vel libero pulvinar, vitae vestibulum ipsum fringilla.", DateCompleted =  DateOnly.FromDateTime(DateTime.Now.AddDays(-3))},
                new ToDoItem(){Title = "Create an app with Blazor", Description="Vivamus ut magna sollicitudin lorem consequat rutrum.", DateCompleted =  DateOnly.FromDateTime(DateTime.Now.AddDays(-7))},
                new ToDoItem(){Title = "Put up Christmas tree", Description="Sed imperdiet justo vel nisl venenatis, at dapibus erat ultrices.", DateCompleted =  DateOnly.FromDateTime(DateTime.Now.AddDays(-2))}
            }).AsQueryable();


            Loading = false;
        }

    }
}
