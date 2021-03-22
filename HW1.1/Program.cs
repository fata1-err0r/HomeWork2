using System;

namespace HW1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[] { 3, 6, 9, 12, 15 }; // целочисленный упорядоченный по возрастанию массив
			int count = 1; // подсчет уникальных цифр

			for (int a = 0; a < nums.Length - 1; a++)
			{
				for (int b = a + 1; b < nums.Length; b++)
				{
					if (nums[a] == nums[b])
						break;

					if (b == nums.Length - 1)
						count++;
				}
			}
			Console.WriteLine($"found {count} different numbers"); // вывод результата в консоль
			Console.ReadKey();
		}
	}
}
