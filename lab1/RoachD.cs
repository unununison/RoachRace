using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lab1
{
	class RoachD : Roaches
	{
		public RoachD(int a, int b) : base (a, b) { }

		public override void Move()
		{
            if (!isFinished)
            {
                Console.SetCursorPosition(0, 3);
                for (int i = 0; i < speed; i++)
                {
                    if (new Random().Next(1, 101) < 15) break;
                    Console.SetCursorPosition(cursorCord, 3);
                    Console.Write("=");
                    Console.SetCursorPosition(cursorCord - 1, 3);
                    Console.Write(".");
                    Thread.Sleep(25);
                    if (cursorCord == 42)
                    {
                        isFinished = true;
                        break;
                    }
                    cursorCord++;
				}
            }
            else
                Thread.Sleep(speed * 25);
        }
	}
}
