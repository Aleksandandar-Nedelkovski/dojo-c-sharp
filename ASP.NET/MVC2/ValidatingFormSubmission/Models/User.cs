using System;
using System.ComponentModel.DataAnnotations;

namespace ValidatingFormSubmission.Models {
    public class User {
        [Required]
        [MinLength (4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength (4)]
        public string LastName { get; set; }
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength (8)]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}