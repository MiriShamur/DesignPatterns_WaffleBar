using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.OrderFactory
{
    internal class CircleFac : WaffleItem
    {
        public CircleFac(WaffelShape shape) : base(shape)
        {
        }
        public override int GetCost()
        {
            return 5;
        }
    }
}
