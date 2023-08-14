using CoreClean.Client.Infrastructure.Services;
using CoreClean.Client.Infrastructure.Settings;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using MudBlazor;

using System.Timers;
namespace CleanCore.Client.Shared
{
    public partial class MainLayout : IDisposable
    {
        public static RefreshService refreshservice;
        private MudTheme _currentTheme;
        private bool _rightToLeft = false;
        private async Task RightToLeftToggle(bool value)
        {
            _rightToLeft = value;
            await Task.CompletedTask;
        }

        protected override async Task OnInitializedAsync()
        {
            _currentTheme = CoreCleanTheme.DefaultTheme;
            _currentTheme = await _clientPreferenceManager.GetCurrentThemeAsync();
            _rightToLeft = await _clientPreferenceManager.IsRTL();
            _interceptor.RegisterEvent();
            RefreshService.Instance().RefreshRequested += RefreshMe;
            timerObj = new System.Timers.Timer(900_000);
            timerObj.Elapsed += UpdateTimer;
            timerObj.AutoReset = false;
            // Identify whether the user is active or inactive using onmousemove and onkeypress in JS function.
            await JSRuntime.InvokeVoidAsync("timeOutCall", DotNetObjectReference.Create(this));
            StateHasChanged();

        }


        private async Task DarkMode()
        {
            bool isDarkMode = await _clientPreferenceManager.ToggleDarkModeAsync();
            _currentTheme = isDarkMode
                ? CoreCleanTheme.DefaultTheme
                : CoreCleanTheme.DarkTheme;
        }

        public void Dispose()
        {
            _authenticationManager.Logout();
            _interceptor.DisposeEvent();
        }
        private async void RefreshMe()
        {
            await InvokeAsync(StateHasChanged);

        }

        private Timer timerObj;
        [Inject] public IJSRuntime JSRuntime { get; set; }

        [JSInvokable]
        public void TimerInterval()
        {
            // Resetting the Timer if the user in active state.
            timerObj.Stop();
            // Call the TimeInterval to logout when the user is inactive.
            timerObj.Start();
        }
        [JSInvokable]
        public void Logout()
        {
            _authenticationManager.Logout();
        }

        private void UpdateTimer(object source, ElapsedEventArgs e)
        {
            InvokeAsync(async () =>
            {
                var user = await _authenticationManager.CurrentUser();
                if (user != null)
                {
                    try
                    {
                        await _authenticationManager.Logout();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            });
        }

    }
}