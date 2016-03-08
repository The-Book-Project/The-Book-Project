namespace TheBookProject.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Повтори парола")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [RegularExpression(@"([a-zA-Z])\w+", ErrorMessage = "Invalid characters used for First name.")]
        [Display(Name = "Име")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [RegularExpression(@"([a-zA-Z])\w+", ErrorMessage = "Invalid characters used for Last name.")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Профилна снимка")]
        public HttpPostedFileBase ProfileImage { get; set; }
    }
}
