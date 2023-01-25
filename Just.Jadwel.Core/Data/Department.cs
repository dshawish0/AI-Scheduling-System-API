using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class Department
    {
        [Key]
        public int departmentId { get; set; }
        public string name { get; set; }
        public int collageId { get; set; }
        [ForeignKey("collageId")]
        public virtual Collage Collage { get; set; }
        public ICollection<User> users { get; set; }
        public ICollection<SuggesteDepartmentSchedule> SuggesteDepartmentSchedules { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<AcademicPlan> AcademicPlans { get; set; }
    }
}
