﻿using System;
using System.Linq;

public class PairsByDifference
{
	public static void Main()
	{
		var numbers = Console.ReadLine()
			.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToArray();
		var difference = int.Parse(Console.ReadLine());
		var count = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			for (int j = i + 1; j < numbers.Length; j++)
			{
				if (Math.Abs(numbers[i] - numbers[j]) == difference)
				{
					count++;
				}
			}
		}

		Console.WriteLine(count);
	}
}