﻿
using HR_Managment.MVC.Contracts;
using System.Net.Http.Headers;

namespace HR_Managment.MVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly IClient _client;
        protected readonly IlocalStorageService _localStorage;
        private Services.IClient client;
        private IlocalStorageService localstorageService;

        public BaseHttpService(IClient client, IlocalStorageService localStorage)
        {
            this._client = client;
            this._localStorage = localStorage;
        }

        public BaseHttpService(Services.IClient client, IlocalStorageService localstorageService)
        {
            this.client = client;
            this.localstorageService = localstorageService;
        }

        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException exception)
        {
            if (exception.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation errors have occured.", ValidationErrors = exception.Response, Success = false };
            }
            else if (exception.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "Not Found ...", Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "Somthing went wrong,try again ... ", Success = false };
            }
        }

        protected void AddBearerToken()
        {
            if(_localStorage.Exists("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _localStorage.GetStorageValue<string>("token"));
            }
        }

    }
}
