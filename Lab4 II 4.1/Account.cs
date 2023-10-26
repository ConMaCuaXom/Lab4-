using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_II_4._1
{
    internal class Account
    {
        public float balance;
        public float initialize;
        public string name = "Tester";
        public string id = "1234";

        public Account(float initialize)
        {
            this.initialize = initialize;
            this.balance = initialize;
        }


        public virtual void Initialize(float money)
        {
            balance += money;    
            Console.WriteLine("Gui tien thanh cong!! ");
            Console.WriteLine("So tien da gui: " + money);
            GetBalance();
        }

        public virtual void WithDraw(float money)
        {
            balance -= money;
            Console.WriteLine("Rut tien thanh cong!! ");
            Console.WriteLine("So tien da rut: " + money);
            GetBalance();
        }

        public void GetBalance()
        {
            Console.WriteLine("Tai khoan {0} dang co {1} dong", name, balance);
        }
    }
}
