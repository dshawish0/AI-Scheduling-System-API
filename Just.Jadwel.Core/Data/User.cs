using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("roleId")]
        public virtual Role Role { get; set; }
        public int departmentId { get; set; }

        [ForeignKey("departmentId")]
        public virtual Department Department { get; set; }

        public ICollection<SuggesteStudentSchedule> SuggesteStudentSchedules { get; set; }
        public ICollection<SuggesteCourse> SuggesteCourses { get; set; }
        public ICollection<NotifyMessage> NotifyMessages { get; set; }
        public ICollection<Login> Logins { get; set; }
        public ICollection<CompletedCourse> CompletedCourse { get; set; }
    }
}
