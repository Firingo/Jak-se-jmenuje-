using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ahoj, jak se jmenuješ?");
			string a = Console.ReadLine();
			Console.WriteLine("Jaký jsi?");
			string b = Console.ReadLine();

			Console.WriteLine(a + " je " + b);
		}
	}
}