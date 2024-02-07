using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			List<string> firstnames = new List<string>();
			string morenames;

			do
			{
				Console.Write("Enter a first name: ");
				firstnames.Add(Console.ReadLine());
				Console.Write("Any more (yes/no)? ");
				morenames = Console.ReadLine();
			} while ( morenames.ToLower() != "no" );

			foreach ( string firstname in firstnames )
			{
				Console.WriteLine($"Hello {firstname}!");
			}

			_ = Console.ReadLine();
		}
	}
}
