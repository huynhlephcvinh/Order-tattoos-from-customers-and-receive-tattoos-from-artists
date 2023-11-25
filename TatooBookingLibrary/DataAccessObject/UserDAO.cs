using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TatooBookingLibrary.Models;

namespace TatooBookingLibrary.DataAccessObject
{
    public class UserDAO
    {
        public UserDAO() { }
        public List<User> GetUsersDAO()
        {
            List<User> list = new List<User>();
            using (var context = new TatooBookingContext())
            {
                list = context.Users.ToList();
            }
            return list;
        }

        public User GetUserDAO(int id)
        {
            User user = new User();
            using (var context = new TatooBookingContext())
            {
                user = context.Users.SingleOrDefault(x => x.Id == id);
            }
            return user;
        }

        public void UpdateUserDAO(User user)
        {
            using (var context = new TatooBookingContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }

        public void SaveUser(User user)
        {
            try
            {
                using (var context = new TatooBookingContext())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static User CheckLogin(string email, string password)
        {
            User user = new User();
            List<User> listCustomer = new List<User>();
            try
            {
                using (var context = new TatooBookingContext())
                {
                    ;
                    listCustomer = context.Users.ToList();
                    foreach (var action in listCustomer)
                    {
                        if (action.Email == email && action.Password == password)
                        {
                            user = action;
                            return user;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
    }
}
