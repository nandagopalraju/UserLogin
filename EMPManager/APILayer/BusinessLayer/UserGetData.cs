using BusinessLayer.Interfaces;
using DataLayer.Services;
using ModelLayer;

namespace BusinessLayer
{
    public class UserGetData : IUserServices
    {
        private readonly DataContext _context;
        public UserGetData(DataContext context)
        {
            _context = context;
        }

        public List<User> Get()
        {
            return null;

        }

    }
}