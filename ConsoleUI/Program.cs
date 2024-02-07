using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
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
