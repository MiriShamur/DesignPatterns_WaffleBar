using System;

namespace DPProj
{
    public class Order : Command.SendOrderToCook
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Phon { get; set; }
        public OrderFactory.WaffelShape Shape { get; set; }
        public int OrderNumber { get; } = 2365;
        public bool IsChocolate { get; set; }
        public bool IsSauce { get; set; }
        public bool IsTea { get; set; }
        public bool IsCoffee { get; set; }
        public bool IsWater { get; set; }
        public bool IsCoke { get; set; }
        public FState.Context CurrentState { get; set; } = new FState.Context();
        public Order(OrderFactory.WaffelShape Shape, string Name, string Phon, int OrderNumber, bool IsChocolate, bool IsSauce, bool IsTea, bool IsCoffee, bool IsWater, bool IsCoke)
        {
            this.Name = Name;
            this.Phon = Phon;
            this.Date = DateTime.Now;
            this.Shape = Shape;
            this.OrderNumber = OrderNumber;
            this.IsChocolate = IsChocolate;
            this.IsCoffee = IsCoffee;
            this.IsCoke = IsCoke;
            this.IsSauce = IsSauce;
            this.IsTea = IsTea;
            this.IsWater = IsWater;

        }
        public Order()
        {

        }
        public Order(Order o,int orderNum)
        {
            this.Name = o.Name;
            this.Shape = o.Shape;
            this.OrderNumber = orderNum;
            this.IsChocolate = o.IsChocolate;
            this.IsCoffee = o.IsCoffee;
            this.IsCoke =o. IsCoke;
            this.IsSauce =o.IsSauce;
            this.IsTea = o.IsTea;
            this.IsWater = o.IsWater;
        }
        public override void Execute(Command.Waiter w)
        {
            int rnd = (int)(new Random().Next(1, Cooks.Count - 1));
            //rnd = 1;
            Cooks[rnd].OrderProduct(this, w);
            CurrentState.State.Handle(this.CurrentState);
        }
    }
}
