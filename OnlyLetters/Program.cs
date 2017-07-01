using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlyLetters
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = @"(\d+)(?<letter>[a-zA-Z])";
			var match = Regex.Match(input, pattern);
			if (match.Success)
			{
				input = Regex.Replace(input, pattern, "$2$2");
			}
			Console.WriteLine(input);
		}
	}
}
