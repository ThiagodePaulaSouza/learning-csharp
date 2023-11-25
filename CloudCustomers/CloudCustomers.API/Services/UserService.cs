using CloudCustomers.API.Models;
using System.Collections;
using System.Collections.Generic;

namespace CloudCustomers.API.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public Task<IList<User>> GetAllUsers()
        {
            IList<User> teste = new List<User>
            {
                new User(1, "João", "joao@gmail.com", new Address("", "", "")),
                new User(2, "Mario", "Mario@gmail.com", new Address("", "", "")),
                new User(3, "José", "José@gmail.com", new Address("", "", "")),
                new User(4, "Mariana", "Mariana@gmail.com", new Address("", "", "")),
                new User(5, "Gabriele", "Gabriele@gmail.com", new Address("", "", ""))
            };

            var outro = teste;

            return Task.FromResult(teste);
        }
    }
}
