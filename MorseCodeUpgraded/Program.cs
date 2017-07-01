using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MorseCodeUpgraded
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Console.WriteLine(translate(input));
		}

		static string translate(string input)
		{
			var sb = new StringBuilder();
			var chars = input.Split('|');
			for (int i = 0; i < chars.Length; i++)
			{
				sb.Append(translateChar(chars[i]));
			}
			return sb.ToString();
		}

		static char translateChar(string input)
		{
			int sum = 0;

			sum += Regex.Matches(Regex.Escape(input), "0").Count * 3;
			sum += Regex.Matches(Regex.Escape(input), "1").Count * 5;

			var findSequences = @"0{2,}|1{2,}";

			var matches = Regex.Matches(input, findSequences);
			foreach (Match sequenceMatch in matches)
			{
				sum += sequenceMatch.Length;
			}
			return (char)sum;
		}
	}
}
