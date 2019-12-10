    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System;


namespace Login_Regis.Models
{
        public class User
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int UserId {get;set;}
            [Required]
            [Display(Name="First Name")]
            public string FirstName {get;set;}
            [Required]
            public string LastName {get;set;}
            [EmailAddress]
            [Required]
            public string Email {get;set;}
            [DataType(DataType.Password)]
            [Required]
            [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]

            public string Password {get;set;}
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
            // Will not be mapped to your users table!
            [NotMapped]
            [Compare("Password")]
            [DataType(DataType.Password)]
            public string Confirm {get;set;}
        }

        public class Login
        {
            [Required]
            public string Email{get;set;}

            [Required]
            public string Password {get;set;}


        }




}