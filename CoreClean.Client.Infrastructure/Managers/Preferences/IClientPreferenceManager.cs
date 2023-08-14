using CoreClean.BCL.Shared.Managers;

using MudBlazor;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Managers.Preferences;

public interface IClientPreferenceManager : IPreferenceManager
{
    Task<MudTheme> GetCurrentThemeAsync();

    Task<bool> ToggleDarkModeAsync();
}