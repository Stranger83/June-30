using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailStatistics
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var pattern = @"(?<user>[a-zA-Z]{5,})@(?<host>[a-z]{3,}\.(bg|com|org)$)";
			var emailDict = new Dictionary<string, List<string>>();
			for (int i = 0; i < n; i++)
			{
				var email = Regex.Match(Console.ReadLine(), pattern);
				if (email.Success)
				{
					if (!emailDict.ContainsKey(email.Groups["host"].Value))
					{
						emailDict[email.Groups["host"].Value] = new List<string>();
					}
					if (!emailDict[email.Groups["host"].Value].Contains(email.Groups["user"].Value))
					{
						emailDict[email.Groups["host"].Value].Add(email.Groups["user"].Value);
					}
				}
			}
									
			foreach (var kvp in emailDict.OrderByDescending(x => x.Value.Count))
			{
				var host = kvp.Key;
				var users = kvp.Value;
				Console.WriteLine($"{host}:");
				foreach (var user in users)
				{
					Console.WriteLine($"### {user}");
				}
			}
		}
	}
}
