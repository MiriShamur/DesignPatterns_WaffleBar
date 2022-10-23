using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Strategy
{
    abstract class StrategyData
    {
        public abstract void Save(Order o);
        public abstract string Read();

    }
}
