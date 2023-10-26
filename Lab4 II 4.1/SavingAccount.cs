using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_II_4._1
{
    internal class SavingAccount : Account
    {
        public float rate;

        public SavingAccount(float balance, float rate) : base(balance)
        {
            this.rate = rate;
            this.balance = balance;
        }

        public void GetInterest()
        {
            Console.WriteLine("So tien lai la: ");
            float lai = initialize * rate;
            Console.WriteLine(lai + "dong");
        }

        

    }
}
