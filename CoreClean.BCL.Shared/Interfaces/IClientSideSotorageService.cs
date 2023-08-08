namespace CoreClean.BCL.Shared.Interfaces
{
    public interface IClientSideStringSotorageService
    {
        public Task<string> GetItemAsync(string key);
        public Task SetItemAsync(string key, string value);
    }
}
