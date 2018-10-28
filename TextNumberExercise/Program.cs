using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextNumberExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please pick a number between 1-50.");
			string userNumber = Console.ReadLine();
			File.WriteAllText(@"C:\Users\Blake\Logs\TextNumber.txt", userNumber);
			Console.WriteLine("Your number is: " + File.ReadAllText(@"C:\Users\Blake\Logs\TextNumber.txt"));
			Console.ReadLine();


		}
	}
}
