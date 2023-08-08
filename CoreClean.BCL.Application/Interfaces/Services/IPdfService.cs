namespace CoreClean.BCL.Application.Interfaces.Services
{
    public interface IPdfService
    {
        Task GeneratePdf(string url, string fileName);
    }
}
