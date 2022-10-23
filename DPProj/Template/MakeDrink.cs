using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Template
{
    class MakeDrink
    {
        public DrinkState DrinkState
        {
            get => default;
            set
            {
            }
        }
        public static void MakeNewDrink(DrinkState drink)
        {
            drink.MakeDrink();
        }
    }
}
