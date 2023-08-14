namespace CoreClean.BCL.Shared.Interfaces
{
    public interface IClientSideStringStorageService
    {
        public Task<string> GetItemAsync(string key);
        public Task SetItemAsync(string key, string value);
    }
}
