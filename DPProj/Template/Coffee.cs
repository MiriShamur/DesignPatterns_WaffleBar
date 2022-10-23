using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Template
{
    class Coffee:HotDrink
    {
        public Coffee()
        {
            Price += 10;
        } 
        public override void AddCoffee()
        {
            Debug.Print("coffee was added");
        }
    }
}
