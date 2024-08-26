namespace HR_Managment.MVC.Contracts
{
    public interface IlocalStorageService
    {
        void ClearStorage(List<string> Keys);
        bool Exists(string Key);
        T GetStorageValue<T>(string Key);
        void SetStorageValue<T>(string key, T value);
    }
}
