using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Service
{
    public interface ICourseService
    {
        public bool InsertCourse(Course course);
        public List<Course> GetCourse();
        public bool UpdateCourse(Course course);
        public bool DeleteCourse(int id);
        public Course GetCourse(int id);
    }
}
