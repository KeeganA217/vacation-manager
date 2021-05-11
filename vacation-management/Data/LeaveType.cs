using System;
using System.ComponentModel.DataAnnotations;

namespace vacation_management.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
