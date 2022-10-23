using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.FState
{
   public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
