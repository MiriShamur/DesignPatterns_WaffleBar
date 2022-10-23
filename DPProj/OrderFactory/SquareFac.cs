using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.OrderFactory
{
     class SquareFac:WaffleItem
    {
        public SquareFac(WaffelShape shape) : base(shape)
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }
}
