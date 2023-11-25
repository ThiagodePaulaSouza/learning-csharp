using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public interface IUsersService
    {
        public Task<IList<User>> GetAllUsers();
    }
}
