using System.ComponentModel.DataAnnotations;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Field can't be empty")]
        [MinLength(5)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MaxLength(100, ErrorMessage = "Too Long")]
        public string Message { get; set; }
    }
}
