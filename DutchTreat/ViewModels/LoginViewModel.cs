using System.ComponentModel.DataAnnotations;

namespace DutchTreat.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Please enter UserName:")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Please enter Password:")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
