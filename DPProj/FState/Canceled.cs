using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.FState
{
    class Canceled:State
    {
        public override void Handle(Context context)
        {
            context.State= new Finish();
        }
    }
}
