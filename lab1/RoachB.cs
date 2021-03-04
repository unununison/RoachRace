using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lab1
{
    class RoachB : Roaches
    {
        public RoachB(int a, int b) : base(a, b)
        {
        }

        public override void Move()
        {
            if (!isFinished)
            {
                Console.SetCursorPosition(0, 1);
                for (int i = 0; i < speed; i++)
                {
                    if (cursorCord % 20 == 0) speed++;
                    Console.SetCursorPosition(cursorCord, 1);
                    Console.Write("=");
                    Console.SetCursorPosition(cursorCord - 1, 1);
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
