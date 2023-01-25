using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class SuggesteStudentSchedule
    {
        [Key]
        public int studentScheduleId { get; set; }
        public string days { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User user { get; set; }
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
