using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.OrderFactory
{
    public abstract class WaffleItem
    {
        public WaffelShape WShape { get; set; }
        public WaffleItem(WaffelShape shape)
        {
            WShape = shape;
        }
        public virtual int GetCost()
        {
            return 15;
        }
    }
}
