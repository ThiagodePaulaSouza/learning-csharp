using CloudCustomers.API.Config;
using CloudCustomers.API.Models;
using Microsoft.Extensions.Options;
using System.Collections;
using System.Collections.Generic;

namespace CloudCustomers.API.Services
{
    public class UsersService : IUsersService
    {
        private readonly HttpClient _httpClient;
        private readonly UsersApiOptions _apiConfig;
        public UsersService(HttpClient httpClient, IOptions<UsersApiOptions> apiConfig)
        {
            _httpClient = httpClient;
            _apiConfig = apiConfig.Value;
        }

        public async Task<IList<User>> GetAllUsers()
        {
            using (var client = _httpClient)
            {
                var response = await client.GetAsync(_apiConfig.Endpoint);
                if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return new List<User>();
                }

                var responseContent = response.Content;
                var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
                return allUsers!.ToList();
            }

            //return new List<User>()
            //{
            //    new User(1, "João", "joao@gmail.com", new Address("", "", "")),
            //    new User(2, "Mario", "Mario@gmail.com", new Address("", "", "")),
            //    new User(3, "José", "José@gmail.com", new Address("", "", "")),
            //    new User(4, "Mariana", "Mariana@gmail.com", new Address("", "", "")),
            //    new User(5, "Gabriele", "Gabriele@gmail.com", new Address("", "", ""))
            //};
        }
    }
}
