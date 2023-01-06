using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;

namespace NewInBlazor.Pages
{
    public partial class DataEntry
    {
        private string text = string.Empty;

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        private IDisposable? registration;


        protected override void OnAfterRender(bool firstRender)
        {
            //if (firstRender)
            //{
            //    registration =
            //        Navigation.RegisterLocationChangingHandler(OnLocationChanging);
            //}
        }

        //private ValueTask OnLocationChanging(LocationChangingContext context)
        //{
        //    if (context.TargetLocation == "/searchtodos" && text != string.Empty)
        //    {
        //        context.PreventNavigation();
        //        //we can display a message to the user saying that navigation is prevented here
        //    }

        //    return ValueTask.CompletedTask;
        //}

        public void Dispose() => registration?.Dispose();


        private async Task OnBeforeInternalNavigation(LocationChangingContext context)
        {
            if (text != string.Empty)
            {
                var confirmed = await JSRuntime.InvokeAsync<bool>("confirm", "You have entered data, are you sure you want to navigate away?");

                if (!confirmed)
                {
                    context.PreventNavigation();
                }
            }
        }

    }
}
