using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Repository
{
    public interface IDepartmentRepository
    {
        public bool InsertDepartment(Department department);
        public List<Department> GetDepartment();
        public bool UpdateDepartment(Department department);
        public bool DeleteDepartment(int id);
        public Department GetDepartment(int id);
    }
}
