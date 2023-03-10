using Just.Jadwel.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just.Jadwel.Core.Service
{
    public interface ICompletedCourseService
    {
        public bool InsertCompletedCourse(CompletedCourse completedCourse);
        public List<CompletedCourse> GetCompletedCourse();
        public bool UpdateCompletedCourse(CompletedCourse completedCourse);
        public bool DeleteCompletedCourse(int id);
        public CompletedCourse GetCompletedCourse(int id);
    }
}
