using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Template
{
    class Tea : HotDrink
    {
        public Tea()
        {
            Price += 8;
        }
        public override void AddTea()
        {
            Debug.Print("tea was added");
        }
    }
}
