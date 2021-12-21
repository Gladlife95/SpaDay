using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="UserName is Required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Name must be between 5 and 15 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        [StringLength(20, MinimumLength =6, ErrorMessage ="Password must be between 6 and 20 characters")]
        public string Password { get; set; }

        
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Must verify password")]
        public string VerifyPassword { get; set; } 
    }

}
