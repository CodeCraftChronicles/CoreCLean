using CoreClean.BCL.Shared.Interfaces;
using CoreClean.BCL.Shared.Settings;

namespace CoreClean.BCL.Shared.Managers;

public interface IPreferenceManager
{
    Task SetPreference(IPreference preference);

    Task<IPreference> GetPreference();

    Task<IResult> ChangeLanguageAsync(string languageCode);
}