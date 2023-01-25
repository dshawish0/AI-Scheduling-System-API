using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class Course
    {
        [Key]
        public int courseId { get; set; }
        public string name { get; set; }
        public int creditHoures { get; set; }
        public int departemntId { get; set; }
        [ForeignKey("departemntId")]
        public virtual Department Department { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<SuggesteDepartmentSchedule> SuggesteDepartmentSchedules { get; set; }
        public ICollection<SuggesteCourse> SuggesteCourses { get; set; }
        public ICollection<AcademicPlan> AcademicPlans { get; set; }
    }
}
