using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			Console.WriteLine(Punch(input));
		}

		private static string Punch(string input)
		{
			int power = 0;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] == '>')
				{
					power += int.Parse(input[i + 1].ToString());

					while (power > 0 && i + 1 < input.Length)
					{
						if (input[i+1] == '>')
						{
							break;
						}
						input = input.Remove(i + 1, 1);
						power--;
					}
				}
			}
			return input;
		}
	}
}
