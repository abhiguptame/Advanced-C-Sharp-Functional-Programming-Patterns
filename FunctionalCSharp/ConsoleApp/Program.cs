﻿using System;
using System.Threading;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Impure Functions Starts
			Timer t = new Timer(TimerCallback, null, 0, 1000);
			Console.ReadLine();

			// Impure Functions Ends

		}


		#region Impure Functions

		private static void TimerCallback(Object o)
		{
			var examples = new ImpureFunctions();
			Console.Clear();
			Console.WriteLine(DateTime.Now);
			var result = examples.GetCurrentTimeRoundedUpToCustomMinuteInterval(4);
			Console.WriteLine(result);
		}

		#endregion

	}
}
