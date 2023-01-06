using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NewInBlazor.Model;

namespace NewInBlazor.Components
{
    public partial class ToDoItemComponent
    {
        [Parameter]
        public ToDoItem ToDoItem { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnDeleteToDoItem { get; set; }

        protected override void OnInitialized()
        {
           
        }
    }
}
