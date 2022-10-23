using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DPProj.FState
{
    class SentToCook : State
    {
        public override void Handle(Context context)
        {     
            context.State = new Treated();
            if (new Random().Next(0, 10) == 4)
            {
                context.State = new Canceled();
                Debug.Print("ההזמנה בוטלה עקב מחסור באחד מהמוצרים");
            }
            
        }
    }
}
