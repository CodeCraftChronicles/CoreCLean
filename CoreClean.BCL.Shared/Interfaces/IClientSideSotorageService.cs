namespace CoreClean.BCL.Shared.Interfaces
{
    public interface IClientSideSotorageService
    {
        public Task<string> GetItemAsync(string key);
        public Task SetItemAsync(string key, object value);
    }
}
