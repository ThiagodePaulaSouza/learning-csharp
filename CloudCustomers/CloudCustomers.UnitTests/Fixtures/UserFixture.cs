using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UserFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User(1, "João", "joao@gmail.com", new Address("", "", "")),
            new User(2, "Mario", "Mario@gmail.com", new Address("", "", "")),
            new User(3, "José", "José@gmail.com", new Address("", "", "")),
            new User(4, "Mariana", "Mariana@gmail.com", new Address("", "", "")),
            new User(5, "Gabriele", "Gabriele@gmail.com", new Address("", "", ""))
        };
    }
}
