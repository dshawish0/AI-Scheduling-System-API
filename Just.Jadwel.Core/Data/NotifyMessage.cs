using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Just.Jadwel.Core.Data
{
    public class NotifyMessage
    {
        [Key]
        public int NotifyMessageId { get; set; }
        public string MyPropMessageerty { get; set; }
        public int UserIdTo { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
