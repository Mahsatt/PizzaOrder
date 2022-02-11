using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrder.DataLayer.Entities
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PizzaName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CookingTime { get; set; }

    }
}
