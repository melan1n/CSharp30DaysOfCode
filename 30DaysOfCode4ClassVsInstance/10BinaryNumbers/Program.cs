using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

	static void Main(String[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());

		//convert n to binary
		var binary = Convert.ToString(n, 2);
		//loop binary string if s=1 increment count, else count = 0

		int maxCount = 0;
		int count = 0;

		for (int i = 0; i < binary.Length; i++)
		{

			if (binary[i] == '1')
			{
				count++;
				if (count > maxCount)
				{
					maxCount = count;
				}
			}
			else
			{
				if (count > maxCount)
				{
					maxCount = count;
					count = 0;
				}
				else
				{
					count = 0;
				}
			}

			
		}
		//print count
		Console.WriteLine(maxCount);
	}
}
