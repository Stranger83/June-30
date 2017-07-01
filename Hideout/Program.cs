using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hideout
{
	class Program
	{
		static void Main(string[] args)
		{
			var map = Console.ReadLine();
			while (true)
			{
				var tokens = Console.ReadLine().Split();
				var pattern = @"\" + tokens[0] + @"{" + tokens[1] + @",}";
				var match = Regex.Match(map, pattern);
				if (match.Success)
				{
					Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
					break;
				}
			}
		}
	}
}
