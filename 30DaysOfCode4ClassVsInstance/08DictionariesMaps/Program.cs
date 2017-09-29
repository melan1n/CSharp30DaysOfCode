using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
	static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		var n = int.Parse(Console.ReadLine());
		Dictionary<string, string> phoneBook = new Dictionary<string, string>();
		
		for (int i = 0; i < n; i++)
		{
			string[] line = Console.ReadLine().Split(' ');
			phoneBook.Add(line[0], line[1]);
		}
		for (int j = 0; j < n; j++)
		{
			var person = Console.ReadLine();
			if (!phoneBook.ContainsKey(person))
			{
				Console.WriteLine("Not found");
			}
			else
			{
				Console.WriteLine("{0}={1}", person, phoneBook[person]);
			}

		}
	}
}