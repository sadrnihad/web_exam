using System.ComponentModel.DataAnnotations;

namespace web_exam.Areas.Admin.ViewModels
{
    public class CreateWorkerVm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
        public string Description { get; set; }
        [Required]
        public IFormFile? ImageUrl { get; set; }
        public string Fullname { get; internal set; }
    }
}
