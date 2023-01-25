using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Service
{
    public interface IUserService
    {
        public bool InsertUser(User user);
        public List<User> GetUser();
        public bool UpdateUser(User user);
        public bool DeleteUser(int id);
        public User GetUser(int id);
    }
}
