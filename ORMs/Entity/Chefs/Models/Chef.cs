using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs.Models {
    public class Chef {
        [Key]
        public int ChefId { get; set; }

        [Required]
        [MinLength (3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength (3)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        [NotMapped]
        public int Age {
            get {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Dish> ChefDishes { get; set; }
    }
}