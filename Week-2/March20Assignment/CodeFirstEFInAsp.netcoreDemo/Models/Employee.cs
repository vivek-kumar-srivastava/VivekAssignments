using System.ComponentModel.DataAnnotations;

namespace CodeFirstEFInAsp.netcoreDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage ="enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="enter your age")]
        [Range(0,130,ErrorMessage ="please enter age between 1-130 only")]
        public int Age { get; set; }
    }
}
