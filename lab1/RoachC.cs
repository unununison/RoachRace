using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lab1
{
	class RoachC : Roaches
	{
		public RoachC(int a, int b) : base(a, b) { }

		public override void Move()
		{
            if (!isFinished)
            {
                int chance = new Random().Next(1, 101);
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i < speed; i++)
                {
					speed = (chance>25) ? speed-- : speed++; 
                    Console.SetCursorPosition(cursorCord, 2);
                    Console.Write("=");
                    Console.SetCursorPosition(cursorCord - 1, 2);
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
        }
	}
}
