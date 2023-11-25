using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.Repository
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public void UpdateUser(User user);
        public void SaveUser(User user);
    }
}
