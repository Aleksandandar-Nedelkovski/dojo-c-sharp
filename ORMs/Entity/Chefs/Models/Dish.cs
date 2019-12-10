using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chefs.Models {
    public class Dish {
        [Key]
        public int DishId { get; set; }

        [Required]
        [MinLength (3)]
        public string Name { get; set; }
        public int ChefId { get; set; }

        [Required]
        [Range (1, 5)]
        public int Tastiness { get; set; }

        [Required]
        [Range (1, 3000)]
        public int Calories { get; set; }
        public Chef Creator { get; set; }

        [MinLength (20)]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}