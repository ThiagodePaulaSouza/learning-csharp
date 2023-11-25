using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public interface IUserService
    {
        public Task<IList<User>> GetAllUsers();
    }
}
