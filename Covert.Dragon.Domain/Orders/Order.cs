using System.Collections.Generic; 
using System.Linq;
using Covert.Dragon.Domain.Orders;

namespace Covert.Dragon.Domain.Orders 
{ 
public class Order 
{ 
    public int Id { get; set ; } 
    public List <OrderItem> Items { get; set; } 
    public DateTime CreatedDate { get; set ; } 
    public decimal TotalPrice => Items.Sum(i => i.Price); 
    }

 
}