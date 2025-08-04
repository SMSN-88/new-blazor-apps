using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace NewBlazorApps.Layout
{
    public partial class MainLayout
    {
        [Inject] IJSRuntime JS { get; set; }

        private bool isDarkMode;

        protected override async Task OnInitializedAsync()
        {
            isDarkMode = await JS.InvokeAsync<bool>("getDarkMode");
        }

        private async Task ToggleDarkMode()
        {
            isDarkMode = !isDarkMode;
            await JS.InvokeVoidAsync("setDarkModeClass", isDarkMode);
        }
    }
}
