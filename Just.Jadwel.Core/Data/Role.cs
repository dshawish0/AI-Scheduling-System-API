using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class Role
    {
        [Key]
        public int roleId { get; set; }
        public string name { get; set; }
        public ICollection<User> users { get; set; }
    }
}
