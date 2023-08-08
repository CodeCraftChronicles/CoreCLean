namespace CoreClean.BCL.Application.Configurations;
public class AppConfiguration
{
    public string Secret { get; set; } = String.Empty;
    public bool BehindSSLProxy { get; set; } = false;
    public string ProxyIP { get; set; } = String.Empty;
    public string ApplicationUrl { get; set; } = String.Empty;
    public string ApplicationName { get; set; } = String.Empty;
    public string ApplicationVersion { get; set; } = String.Empty;
    public string ConfigFilesRepository { get; set; } = string.Empty;
}