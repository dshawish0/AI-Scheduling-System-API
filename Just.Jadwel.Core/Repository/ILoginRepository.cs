using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Repository
{
    public interface ILoginRepository
    {
        public bool InsertLogin(Login login);
        public List<Login> GetLogin();
        public bool UpdateLogin(Login login);
        public bool DeleteLogin(int id);
        public Login GetLogin(int id);
    }
}
