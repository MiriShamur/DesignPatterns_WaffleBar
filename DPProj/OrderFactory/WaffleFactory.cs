using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPProj.Waffledecorator;
namespace DPProj.OrderFactory
{
    internal class WaffleFactory
    {
        public static WaffleItem Create(WaffelShape s)
        {
            switch (s)
            {
                case WaffelShape.Circle:
                    return new CircleFac(s);
                case WaffelShape.Square:
                    return new SquareFac(s);
            }
            return null;
        }
    }
}
