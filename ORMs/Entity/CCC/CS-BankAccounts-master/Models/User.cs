using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models {
    public class User {

        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "First name is required.")]
        [MinLength (2, ErrorMessage = "First Name must be at least 2 characters.")]
        [Display (Name = "First Name:")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Last name is required.")]
        [MinLength (2, ErrorMessage = "Last Name must be at least 2 characters.")]
        [Display (Name = "Last Name:")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Email is required.")]
        [EmailAddress]
        [Display (Name = "Email Address:")]
        public string Email { get; set; }

        public double Balance { get; set; } = 200.00;

        [Required (ErrorMessage = "Password is required.")]
        [MinLength (8, ErrorMessage = "Password must be at least 8 characters.")]
        [DataType (DataType.Password)]
        [Display (Name = "Password:")]
        public string Password { get; set; }
        public List<Transaction> Transactions { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Required (ErrorMessage = "Confirm Password is required.")]
        [NotMapped]
        [Compare ("Password")]
        [DataType (DataType.Password)]
        [Display (Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }
    }
}