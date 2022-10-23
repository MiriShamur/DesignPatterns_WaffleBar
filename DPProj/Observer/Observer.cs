using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Observer
{
    public abstract  class Observer
    {
        public abstract void Update(Product product,Order o);
    }
}
