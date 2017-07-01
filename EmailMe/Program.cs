using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMe
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split('@');
			var first = input[0].Sum(x => (int)x);
			var second = input[1].Sum(x => (int)x);
			var result = first - second;

			if (result >= 0)
			{
				Console.WriteLine("Call her!");
			}
			else
			{
				Console.WriteLine("She is not the one.");
			}
		}
	}
}
