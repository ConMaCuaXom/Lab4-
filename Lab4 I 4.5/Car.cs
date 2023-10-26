using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._5
{
    internal class Car : IMovable
    {

        private bool started = false;
        public void Start()
        {
            Console.WriteLine("Car started");
            started = true;
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped");
            started = false;
        }

        public bool Started
        {
            get { return started; }
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turning left");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car turning right");
        }

        public void Accelerate()
        {
            Console.WriteLine("Car accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Car braking");
        }
    }
}
