using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
