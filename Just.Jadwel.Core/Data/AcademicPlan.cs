using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class AcademicPlan
    {
        [Key]
        public int academicPlanId { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
        public int departemntId { get; set; }
        [ForeignKey("departemntId")]
        public virtual Department Department { get; set; }
        public ICollection<CompletedCourse> CompletedCourses { get; set; }
    }
}
