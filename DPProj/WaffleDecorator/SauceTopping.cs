using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Waffledecorator
{
    internal class SauceTopping:WaffleDecorate
    {
        public SauceTopping(OrderFactory.WaffleItem waffle, OrderFactory.WaffelShape shape) : base(waffle,shape)
        {
            Debug.Print($"add sauces");
        }
        public override int GetCost()
        {
            return base.GetCost() + 8;
        }
    }
}
