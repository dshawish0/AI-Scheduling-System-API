using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class CompletedCourse
    {
        [Key]
        public int completedCourseId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int acadmicPlanId { get; set; }
        [ForeignKey("acadmicPlanId")]
        public virtual AcademicPlan AcademicPlan { get; set; }

    }
}
