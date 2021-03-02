using System;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace lab1
{
    class Program
    {

		static void Main(string[] args)
		{

            RoachA roachA = new RoachA(new Random().Next(1, 6), 8);
			RoachB roachB = new RoachB(new Random().Next(1, 6), 8);
            RoachC roachC = new RoachC(new Random().Next(1, 6), 8);
            RoachD roachD = new RoachD(new Random().Next(1, 6), 8);

            Roaches[] roaches = { roachA, roachB, roachC, roachD };
            new Race(roaches);
        }
    }
}
