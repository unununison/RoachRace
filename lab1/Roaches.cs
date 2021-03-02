using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Roaches
    {
        public int speed;
        public int cursorCord;
        public bool isFinished = false;

        public Roaches(int a, int b)
        {
            speed = a;
            cursorCord = b;
        }

		public virtual void Move()
        {
            Console.WriteLine("Speed is ");
        }


    }
}
