using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class Collage
    {
        [Key]
        public int collageId { get; set; }
        public string name { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
