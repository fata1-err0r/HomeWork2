using System;

namespace HW1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] mas = new int[5,5] { { 3, 6, 9, 12, 15 }, { 3, 6, 9, 12, 15 }, { 3, 6, 9, 12, 15 }, { 3, 6, 9, 12, 15 }, { 3, 6, 9, 12, 15 } };

			int rows = mas.GetUpperBound(0) + 1;        // количество рядов
			int columns = mas.GetUpperBound(1) + 1;     // количество столбцов

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write($"{mas[i, j]} \t");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
