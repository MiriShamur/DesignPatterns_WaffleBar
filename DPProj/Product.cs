using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj
{
    public class Product
    {
        public string Customer { get; set; }
        public OrderFactory.WaffleItem TheWaffle { get; set; }
        public List<Template.DrinkState>  TheDrink { get; set;}=new List<Template.DrinkState>();    
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; } = 2536;    
        public int Price { get; set; } 
        public Product(int num)
        {
            OrderNumber = num;
            Price = 0;
        }
    }
}
