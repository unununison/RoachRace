using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lab1
{
    class RoachA : Roaches
    {
        
        public RoachA(int a, int b) : base(a, b)
        {
        }

		public override void Move()
        {
            if (!isFinished)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < speed; i++)
                {
                    if (new Random().Next(1, 101) < 35) break;
                    Console.SetCursorPosition(cursorCord, 0);
                    Console.Write("=");
                    Console.SetCursorPosition(cursorCord-1, 0);
                    Console.Write(".");
                    Thread.Sleep(25);

                    if (cursorCord == 42)
                    {
                        isFinished = true;
                        break;
                    }
                    cursorCord++;                    
                }               
            } else
                Thread.Sleep(speed * 25);
        }
    }
}
