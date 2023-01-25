using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class SuggesteCourse
    {
        [Key]
        public int suggesteCourseId { get; set; }
        public int courseId { get; set; }
        [ForeignKey("courseId")]
        public virtual Course Course { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
