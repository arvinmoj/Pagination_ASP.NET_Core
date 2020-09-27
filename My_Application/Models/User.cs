using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace My_Application.Models
{
    [Table("User")]
    public class User
    {
        public User() : base()
        {
            Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="FirstName")]
        [Required(ErrorMessage = "Required {0}")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="LastName")]
        [Required(ErrorMessage = "Required {0}")]
        public string LastName { get; set; }

        [Display(Name ="UserId")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required {0}")]
        public int UserId { get; set; }

        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Required {0}")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please Enter Correct email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Required {0}")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required {0}")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        public string Password { get; set; }

        [Display(Name = "Admin")]
        [Required(ErrorMessage = "Required {0}")]
        public bool IsAdmin { get; set; }

    }
}
