using System;

namespace HW1._2            // сложность алгоритма - Квадратичный - O(n2)
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
			int symmetry = 1; // проверка симметричности
			int matrixRow = 1; // оптимизация проверки, чтобы не сравнить диагональ дважды
			for (int i = 0; i < mas.GetLength(0); i++)
			{
				for (int j = matrixRow; j < mas.GetLength(1); j++)
				{
					int check = mas[i, j] - mas[j, i];
					if (check != 0) symmetry = 0;
				}
				matrixRow++;
			}
			if (symmetry == 1)
			{
				Console.WriteLine("matrix is symmetric ");
			}
			else
			{
				Console.WriteLine("matrix is not symmetric ");
			}
			Console.ReadKey();
		}
	}
}
