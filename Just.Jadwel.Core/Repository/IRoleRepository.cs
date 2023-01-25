using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Repository
{
    public interface IRoleRepository
    {
        public bool InsertRole(Role role);
        public List<Role> GetRole();
        public bool UpdateRole(Role role);
        public bool DeleteRole(int id);
        public Role GetRole(int id);
    }
}
