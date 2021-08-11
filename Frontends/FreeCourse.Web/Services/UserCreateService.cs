using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using FreeCourse.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public class UserCreateService : IUserCreateService
    {
        private readonly HttpClient _httpClient;

        public UserCreateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseDto<bool>> SignUp(SingUpInput singUpInput)
        {
            await _httpClient.PostAsJsonAsync<SingUpInput>("/api/user/signup", singUpInput);

            return ResponseDto<bool>.Success(200);
        }
    }
}
