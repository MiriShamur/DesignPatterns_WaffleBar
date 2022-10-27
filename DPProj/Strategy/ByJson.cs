using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPProj.Strategy
{
    internal class ByJson : StrategyData
    {
        public override string Read()
        {
            FileStream fs = new FileStream(@"C:\Users\User\Desktop\שנה ב\c#\ש.ב\מחצית ב\שרה פרידרויצר ומירי שמור פרויקט design pattern\DPProj\last Orders.json",
            FileMode.Open,
                                     FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            string str = reader.ReadLine();
            reader.Close();
            fs.Close();
            return str;
        }

        public override void Save(Order o)
        {
            string JSON = JsonConvert.SerializeObject(o);
            string path = @"C:\Users\User\Desktop\שנה ב\c#\ש.ב\מחצית ב\שרה פרידרויצר ומירי שמור פרויקט design pattern\DPProj\last Orders.json";
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JSON.ToString());
                tw.Close();
            }
        }
    }
}
