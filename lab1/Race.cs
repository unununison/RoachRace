using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Diagnostics;

namespace lab1
{
	class Race
	{
		private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
		public Race(Roaches[] roaches)
		{
			GenerateField(roaches);
			StartRace(roaches);
			RestartOrCloseRace();		
		}

		private void GenerateField(Roaches[] roaches)
		{
			Console.CursorVisible = false;
			for (int i = 0; i < roaches.Length; i++)
				Console.WriteLine("Roach" + alphabet[i] + "[....................................]");
		}

		private void StartRace(Roaches[] roaches)
		{
			var flags = new bool[roaches.Length];
			var flagsTrue = new bool[roaches.Length];
			for (int i = 0; i < roaches.Length; i++)
				flagsTrue[i] = true;
			do
			{
				for (int i = 0; i < roaches.Length; i++)
				{
					roaches[i].Move();
					flags[i] = roaches[i].isFinished;				
					Thread.Sleep(15);
				}
				if (flags.SequenceEqual(flagsTrue)) break;
			} while (true);
		}

		private void RestartOrCloseRace()
		{
			int game;
			Console.SetCursorPosition(0, 6);
			do
			{
				Console.Write("Enter 1 to restar race or 0 to close the console ");
				game = Convert.ToInt32(Console.ReadLine());
			} while (game < 0 || game > 1);

			if (game == 1)
			{
				Console.Clear();
				Process.Start(Environment.CurrentDirectory + "/lab1.exe");
				Environment.Exit(0);
			}
			else Environment.Exit(0);
		}
	}
}
