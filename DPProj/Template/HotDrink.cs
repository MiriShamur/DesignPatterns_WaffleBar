using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Template
{
    public abstract class HotDrink : DrinkState
    {
        public override void Mix()
        {
            Debug.Print("Mix");
        }
        public override void AddSugar()
        { 
            Debug.Print("add sugar"); 
        }
    }
}
