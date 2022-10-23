using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Template
{
    public abstract class DrinkState
    {
        public int Price=0;
        public void GetCup()
        {
            Debug.Print("cup was taken");
        }
        public virtual void AddCoffee() { }
        public virtual void AddSugar() { }
        public virtual void AddTea() { }
        public virtual void Mix() { }
        public void Pour()
        {
            string liquid=GetType().Name;

            if (this is HotDrink)
            {
                liquid = "hot water";
            }
            if (this is Coffee)
            {
                liquid += " and milk";
            }
            Debug.Print($"Pouring {liquid}");
        }
        public void MakeDrink()
        {
            GetCup();
            AddCoffee();
            AddSugar();
            AddTea();
            Pour();
            Mix();
        }
    }
}
