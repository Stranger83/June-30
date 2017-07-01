using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			int startIndex = 0;
			int endIndex = 0;
			while ((startIndex = input.IndexOf("<", startIndex)) > 0
				&& (endIndex = input.IndexOf(">", startIndex)) > 0)
			{
				var bombChars = input.Substring(startIndex + 1, 2);
				int bombStrength = CalcBombStrength(bombChars);
				int startDestructionIndex = Math.Max(0, startIndex - bombStrength);
				int endDestructionIndex = Math.Min(input.Length - 1, endIndex + bombStrength);
				var sb = new StringBuilder(input);
				for (int i = startDestructionIndex; i <= endDestructionIndex; i++)
				{
					sb[i] = '_';
				}
				input = sb.ToString();
			}
			Console.WriteLine(input);
		}

		private static int CalcBombStrength(string bombChars)
		{
			return Math.Abs(bombChars[0] - bombChars[1]);
		}
	}
}
