using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DPProj.FState
{
   public class Context
    {
        private State state;
        public State State
        {
            get { return state; }
            set
            { 
                state = value;
                Debug.Print($"מצב הזמנה: {state.GetType().Name}{state.ToString()}");
            }
        }

        public Context()
        {
            this.state =new SentToWaiter();

        }
        public void request()
        {
            state.Handle(this);
        }
    }
}
