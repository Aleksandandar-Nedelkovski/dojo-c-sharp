using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models {
    public class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength (2, ErrorMessage = "First Name must be 2 characters or longer!")]
        public string FirstName { get; set; }

        [Required]
        [MinLength (2, ErrorMessage = "Last Name must be 2 characters or longer!")]
        public string LastName { get; set; }

        [DataType (DataType.Password)]
        [Required]
        [MinLength (8, ErrorMessage = "Password must be 8 characters or longer!")]
        public string Password { get; set; }

        [NotMapped]
        [Compare ("Password")]
        [DataType (DataType.Password)]
        public string CPW { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}