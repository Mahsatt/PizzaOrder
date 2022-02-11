using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrder.DataLayer.Entities
{
    public class OrderDetaile
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        [Required]
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public bool State { get; set; }
        public virtual ICollection<Pizza> Pizzas { get; set; }

    }
}
