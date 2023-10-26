using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_II_4._1
{
    internal class CheckAccount : Account
    {
        public float feeTransfer;

        public CheckAccount(float initialize, float fee) : base(initialize)
        {
            this.feeTransfer = fee;
            this.initialize = initialize;
        }

        public override void Initialize(float money)
        {
            balance += money;
            balance -= feeTransfer;
            Console.WriteLine("Gui tien thanh cong!! ");
            Console.WriteLine("So tien da gui: " + money);
            GetBalance();
        }

        public override void WithDraw(float money)
        {
            balance -= money;
            balance -= feeTransfer;
            Console.WriteLine("Rut tien thanh cong!! ");
            Console.WriteLine("So tien da rut: " + money);
            GetBalance();
        }

    }
}
