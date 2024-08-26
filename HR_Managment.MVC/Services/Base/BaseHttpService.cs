using HR_Managment.MVC.Contracts;
using System.Net.Http.Headers;

namespace HR_Managment.MVC.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient _client;
        private readonly IlocalStorageService _localStorageService;
        public BaseHttpService(IClient client, IlocalStorageService localStorageService)
        {
            _client = client;
            _localStorageService = localStorageService;
        }

        protected Response<Guid> ConvertApiException<Guid>(ApiException exception)
        {
            if (exception.StatusCode == 400)
            {
                return new Response<Guid>()
                {
                    Message = "Validation error have occourd.",
                    ValidationError = exception.Response,
                    Success = true
                };

            }
            else if (exception.StatusCode == 404)
            {
                return new Response<Guid>()
                {
                    Message = "Not Found...",
                    ValidationError = exception.Response,
                    Success = false
                };
            }
            return new Response<Guid>() { };
        }



        protected void AddBearerToken()
        {
            if (_localStorageService.Exists("Token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _localStorageService.GetStorageValue<string>("Token"));
            }
        }
    }
}
