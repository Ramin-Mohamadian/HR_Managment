using Hanssens.Net;
using HR_Managment.MVC.Contracts;

namespace HR_Managment.MVC.Services
{
    public class localStorageService : IlocalStorageService
    {

        LocalStorage _store;
        public localStorageService()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "HR_ManagmentLeave"
            };
            _store = new LocalStorage(config);
        }
        public void ClearStorage(List<string> Keys)
        {
            foreach (var key in Keys)
            {
                _store.Remove(key);
            }
        }

        public T GetStorageValue<T>(string Key)
        {
            return _store.Get<T>(Key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _store.Store(key, value);
            _store.Persist();
        }

        public bool Exists(string Key)
        {
            return _store.Exists(Key);
        }

        

       
    }
}
