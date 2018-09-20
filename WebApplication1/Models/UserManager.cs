using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserManager
    {
        private DataContext _Context;

        public UserManager()
        {
            _Context = new DataContext();
        }

        public bool ValidateUser(string userName, string password)
        {
            var result = _Context.UserMasters.SingleOrDefault(x => x.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                        && x.Password == password);

            return result != null;
        }
    }
}