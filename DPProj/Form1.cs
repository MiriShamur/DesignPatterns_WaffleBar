using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
//using Newtonsoft.Json;
using static System.IO.FileStream;
using Newtonsoft.Json;
using System.Diagnostics;
namespace DPProj
{
    public partial class Form1 : Form
    {
        Strategy.StrategyData json = new Strategy.ByJson();
        List<Order> lastOrders = new List<Order>();
        int top = 460;
        int left = 500;
        List<Command.Waiter> TheWaiter = new List<Command.Waiter>() { new Command.Waiter("I'm the waiter"), new Command.Waiter("I'm the second waiter") };
        public Command.Cook cook = new Command.Cook("Im the Cook");
        int orderNumber = 2536;
        OrderFactory.WaffelShape shape;
        int rnd;
        public Form1()
        {
            InitializeComponent();
            lblDate.Text += DateTime.Now.ToString();
            NewOrder();
        }
        public void NewOrder()
        {
            tbOrderNumber.Text = (++orderNumber).ToString();
            rbRoundBelgianWaffle.Checked = false;
            rbSquareBelgianWaffle.Checked = false;
            cbChocolate.Checked = false;
            cbSauces.Checked = false;
            cbTea.Checked = false;
            cbColdCola.Checked = false;
            cbColdWater.Checked = false;
            cbCoffee.Checked = false;
            tbName.Text = "";
            tbPhon.Text = "";
            tbPn.Text = "";
            cbChocolate.Enabled = false;
            cbSauces.Enabled = false;
            dgvLaslOrder.DataSource = "";
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Order customer;
            if (dgvLaslOrder.RowCount > 0)
            {
                customer = new Order(dgvLaslOrder.SelectedRows[0].DataBoundItem as Order, orderNumber)
                {
                    Date = DateTime.Now
                };
            }
            else
            {
                if (rbRoundBelgianWaffle.Checked == true)
                {
                    shape = OrderFactory.WaffelShape.Circle;
                }
                else
                {
                    if (rbSquareBelgianWaffle.Checked == true)
                    {
                        shape = OrderFactory.WaffelShape.Square;
                    }
                    else shape = OrderFactory.WaffelShape.Isnull;
                }
                customer = new Order(shape, tbName.Text,tbPhon.Text, orderNumber, cbChocolate.Checked, cbSauces.Checked, cbTea.Checked, cbCoffee.Checked, cbColdWater.Checked, cbColdCola.Checked);
            }
            rnd = new Random().Next(0, TheWaiter.Count - 1);
            TheWaiter[rnd].ExecuteSendOrder(customer);
            lastOrders.Add(customer);                                                                                       //במקום לקרוא מהjson
            json.Save(customer);
            NewOrder();
            tbOrders.Text = $"\tהזמנה מספר: {orderNumber - 1} הועברה למטבח,\t";

        }
        private void WriteNum(object sender, EventArgs e)
        {
            tbPn.Text = tbPhon.Text;
        }
        private void BtnSName_Click(object sender, EventArgs e)
        {
           string str= json.Read();
           /* FileStream fs = new FileStream(@"C:\Users\User\Desktop\שנה ב\c#\ש.ב\מחצית ב\שרה פרידרויצר ומירי שמור פרויקט design pattern\DPProj\last Orders.json",
            FileMode.Open,
                                     FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string str = reader.ReadLine(); */
            List<Order> last = lastOrders.FindAll(l => l.Phon == tbPn.Text);
            dgvLaslOrder.DataSource = last;
            /*reader.Close();
            fs.Close();*/
        }
        private void RbRoundBelgianWaffle_CheckedChanged(object sender, EventArgs e)
        {
            CbEnabled();
        }
        private void RbSquareBelgianWaffle_CheckedChanged(object sender, EventArgs e)
        {
            CbEnabled();
        }
        public void CbEnabled()
        {
            cbChocolate.Enabled = true;
            cbSauces.Enabled = true;
        }
        public void PayForOrder(int on)
        {
            Button button = new Button
            {
                Left = left,
                Top = top
            };
            left += 90;
            if (left > 1000)
            {
                left = 500;
                top += 60;
            }
            if (top > 560)
            {
                left = 500;
                top = 450;
            }
            button.Width = 80;
            button.Height = 50;
            button.ForeColor = Color.DarkSeaGreen;
            button.Name = $"b{left}{top}";
            button.Click += new EventHandler(this.ButtonClick);
            Controls.Add(button);
            button.Text = $"הזמנה מספר: {on}";
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Debug.Print("התשלום עבר בהצלחה");
        }
        private async void Shef_Click(object sender, EventArgs e)
        {
            if (Command.Cook.Orders.Count == 0)
            {
                Task.Delay(3000).Wait();
                tbOrders.Text = $"אין הזמנות  ";
            }
            else
            {
                Product p = cook.TheCookCreate();
                if (p.Price != 0)
                {
                    await Task.Delay(3000);
                    tbOrders.Text += $"\tהזמנה מספר: {p.OrderNumber} ממתינה לתשלום {p.Price} ש\"ח,\n";
                    PayForOrder(p.OrderNumber);
                }
                else
                {
                    tbOrders.Text += $"הזמנה מספר {p.OrderNumber}בוטלה עקב מחסור באחד החומרים";
                }
            }

        }
    }
}
