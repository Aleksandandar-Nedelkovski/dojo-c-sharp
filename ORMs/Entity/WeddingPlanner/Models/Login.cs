using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models {
    public class Login {
        [Required]
        [EmailAddress]
        public string EmailLogin { get; set; }

        [Required]
        [DataType (DataType.Password)]
        public string PasswordLogin { get; set; }
    }
}