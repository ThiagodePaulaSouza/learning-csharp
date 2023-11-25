using CloudCustomers.API.Models;
using System.Collections;
using System.Collections.Generic;

namespace CloudCustomers.API.Services
{
    public class UsersService : IUsersService
    {
        private readonly HttpClient _httpClient;
        public UsersService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<User>> GetAllUsers()
        {
            using var client = _httpClient;
            var response = await client.GetAsync("https://example.com");
            if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new List<User>();
            }

            var responseContent = response.Content;
            var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
            return allUsers!.ToList();

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
