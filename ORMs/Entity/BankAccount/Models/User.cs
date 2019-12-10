using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.Models {
    public class User {
        [Key]
        public int UserId { get; set; }

        [Required (ErrorMessage = "First name is required.")]
        [MinLength (2, ErrorMessage = "First Name must be 2 characters or longer!")]
        [Display (Name = "First Name:")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Last name is required.")]
        [MinLength (2, ErrorMessage = "Last Name must be 2 characters or longer!")]
        [Display (Name = "Last Name:")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Email is required.")]
        [EmailAddress]
        [Display (Name = "Email Address:")]
        public string Email { get; set; }
        public double Balance { get; set; } = 200.00;

        [Required (ErrorMessage = "Password is required.")]
        [MinLength (8, ErrorMessage = "Password must be 8 characters or longer!")]
        [DataType (DataType.Password)]
        [Display (Name = "Password:")]
        public string Password { get; set; }

        public List<Transaction> Transactions { get; set; }

        [NotMapped]
        [Required (ErrorMessage = "Confirm Password is required.")]
        [Compare ("Password")]
        [DataType (DataType.Password)]
        [Display (Name = "Confirm Password:")]
        public string CPW { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}