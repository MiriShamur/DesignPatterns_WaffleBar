using DPProj.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DPProj.Command
{
    public class Waiter :Observer.Observer
    {
        private string name;
        
        public Waiter(string name)
        {
            this.name = name;
        }
        public void ExecuteSendOrder(Order o)
        {
            o.Execute(this);
           /* if (o.CurrentState.State is FState.Canceled)
            {
                Debug.Print("canceld");
                return ;
            }*/
        }
        public override void Update(Product product,Order o)
        {
           o.CurrentState.State.Handle(o.CurrentState);
           Debug.Print($"מנה מספר {o.OrderNumber} של{o.Name} מוכנה");
           // Cook.Detach(this);
        }
    }
}
