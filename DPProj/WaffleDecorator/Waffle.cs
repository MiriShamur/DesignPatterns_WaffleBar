using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPProj.Waffledecorator
{
    public class Waffle : OrderFactory.WaffleItem
    {
        public Waffle(OrderFactory.WaffelShape shape):base( shape)
        {
            Debug.Print($"make a {shape} waffle");
        }
    }
}
