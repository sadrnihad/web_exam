using System.ComponentModel.DataAnnotations;
using web_exam.Models.Base;

namespace web_exam.Models
{
    public class Worker : BaseEntity
    {
        [MaxLength(50)]
        public string Fullname { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Required, MaxLength(100)]
        public string Designation { get; set; }
        [Required]
        public string Image { get; set; }

        
    }
}
