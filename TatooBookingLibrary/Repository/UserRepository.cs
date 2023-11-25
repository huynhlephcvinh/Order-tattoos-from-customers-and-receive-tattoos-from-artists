using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.DataAccessObject;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserDAO userDAO = new UserDAO();

        public List<User> GetUsers()
        {
            return userDAO.GetUsersDAO();
        }

        public void SaveUser(User user)
        => userDAO.SaveUser(user);

        public void UpdateUser(User user)
        {
            userDAO.UpdateUserDAO(user);
        }
    }
}
