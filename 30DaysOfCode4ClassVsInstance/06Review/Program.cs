using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
	static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = int.Parse(Console.ReadLine());
		for (int i = 0; i < t; i++)
		{
			var s = Console.ReadLine();
			var evens = string.Empty;
			var odds = string.Empty;

			for (int j = 0; j < s.Length; j++)
			{
				if (j % 2 == 0)
				{
					evens += s[j];
				}
				else
				{
					odds += s[j];
				}
			}
			Console.WriteLine("{0} {1}", evens, odds);

		}
	}
}
