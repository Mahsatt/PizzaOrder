using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrder.DataLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderTime { get; set; }
        public virtual ICollection<OrderDetaile> OrderDetailes { get; set; }

    }
}
