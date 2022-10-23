using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Strategy
{
    internal class ByDB : StrategyData
    {
        public override string Read()
        {
            return "";
        }

        public override void Save(Order o)
        {
            
        }
    }
}
