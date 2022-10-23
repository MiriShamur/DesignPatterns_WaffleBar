using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace DPProj.Command
{
    public class Cook
    {
        public static Queue<Order> Orders { get; set; } = new Queue<Order>();
        public string CookName { get; set; }

        private static List<Observer.Observer> Observer = new List<Observer.Observer>();
        public Cook(string name)
        {
            CookName = name;
        }
        public void Add(Observer.Observer observer)
        {
            Observer.Add(observer);
        }
        public static void Detach(Observer.Observer observer)
        {
            Observer.Remove(observer);
        }

        public void RingTheBell(Product product, Order order)
        {
            foreach (Observer.Observer o in Observer)
            {
                o.Update(product, order);
            }
        }

        public void OrderProduct(Order o, Waiter waiter)
        {
            Add(waiter);
            Orders.Enqueue(o);
            //new Order(o.Shape, o.Name, o.OrderNumber, o.IsChocolate, o.IsSauce, o.IsTea, o.IsCoffee, o.IsWater, o.IsCoke)
        }
        public Product TheCookCreate()
        {
            Order order;
            if (Orders.Count > 0)
            {
                order = Orders.Dequeue();
                return CreateProducts(order);
            }
            return null;
        }
        public Product CreateProducts(Order o)
        {
            Product p = new Product(o.OrderNumber);
            o.CurrentState.State.Handle(o.CurrentState);
            if (o.CurrentState.State is FState.Treated)
            {
                if (o.Shape != OrderFactory.WaffelShape.Isnull)
                {
                    OrderFactory.WaffleItem w = OrderFactory.WaffleFactory.Create(o.Shape);
                    p.Price += w.GetCost();
                    if (o.IsChocolate && o.IsSauce)
                    {
                        OrderFactory.WaffleItem wa = new Waffledecorator.SauceTopping(w, o.Shape);
                        p.TheWaffle = new Waffledecorator.ChocolareTopping(wa, o.Shape);
                        p.Price += wa.GetCost();
                        p.Price += p.TheWaffle.GetCost();
                        p.Price -= 15;
                    }
                    else
                    if (o.IsSauce)
                    {
                        p.TheWaffle = new Waffledecorator.SauceTopping(w, o.Shape);
                        p.Price += p.TheWaffle.GetCost();
                    }
                    else
                    if (o.IsChocolate)
                    {
                        p.TheWaffle = new Waffledecorator.ChocolareTopping(w, o.Shape);
                        p.Price += p.TheWaffle.GetCost();
                    }
                }

                if (o.IsTea)
                {
                    p.TheDrink.Add(new Template.Tea());

                }
                if (o.IsCoffee)
                {
                    p.TheDrink.Add(new Template.Coffee());

                }
                if (o.IsWater)
                {
                    p.TheDrink.Add(new Template.Water());
                }
                if (o.IsCoke)
                {
                    p.TheDrink.Add(new Template.Coke());
                }

            }
            foreach (var d in p.TheDrink)
            {
                Template.MakeDrink.MakeNewDrink(d);
                p.Price += d.Price;
            }
            RingTheBell(p, o);
            return p;
        }
    }
}
