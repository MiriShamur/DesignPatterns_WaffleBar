using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Waffledecorator
{
    abstract class WaffleDecorate:Waffle
    {
        protected OrderFactory.WaffleItem waffle;
        public WaffleDecorate(OrderFactory.WaffleItem waffle, OrderFactory.WaffelShape shape) :base(shape)
        {
            this.waffle = waffle;
        }
    }
}
