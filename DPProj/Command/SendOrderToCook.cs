using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Command
{
  public abstract class SendOrderToCook
    {
        public  List< Cook> Cooks =new List<Cook>() { new Cook("i am cook"), new Cook("i am second cook"), new Cook("i am another cook")};
        public abstract void Execute( Waiter w);
    }
}
