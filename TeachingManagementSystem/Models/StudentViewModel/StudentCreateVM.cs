using System.ComponentModel.DataAnnotations;

namespace TeachingManagementSystem.Models.StudentViewModel
{
    public class StudentCreateVM
    {
        public int StudentId { get; set; }

        [Required]
        public string? StudentFirstName { get; set; }
        [Required(ErrorMessage = "Please give your last Name")]
        public string? StudentLastName { get; set; }
        public string? StudentEmail { get; set; }
        public string? Gender { get; set; }
        public int MobileNumber { get; set; }






    }
}
