using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Censorship
{
	class Program
	{
		static void Main(string[] args)
		{
			var word = Console.ReadLine();
			var sentence = Console.ReadLine();
			var match = Regex.Replace(sentence, word, new string('*', word.Length));
			Console.WriteLine(match);
		}
	}
}
