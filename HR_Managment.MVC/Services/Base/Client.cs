using System.Net.Http;

namespace HR_Managment.MVC.Services.Base
{
    public partial class Client : IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                return HttpClient;
            }
        }
    }
}
