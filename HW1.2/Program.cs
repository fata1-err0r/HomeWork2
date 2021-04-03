using System;

namespace HW1._2            // сложность алгоритма - Квадратичный - O(n2)
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер квадратной матрицы ");
			int arraySize = MasValue();
			int[,] mas = new int[arraySize, arraySize];
			for (int i = 0; i < mas.GetLength(0); i++) // Цикл для ввода значений
			{
				for (int j = 0; j < mas.GetLength(1); j++)
				{
					Console.Write($"{i + 1},{j + 1} значение массива: ");
					mas[i, j] = MasNums();
				}
			}
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
			for (int i = 0; i < mas.GetLength(0); i++)
			{
				for (int j = symmetry; j < mas.GetLength(1); )
				{
					if (mas[i, j] != mas[j, i])
					{
						Console.WriteLine("\nМатрица не симметрична ");
						return;
					}
					else
					{
						Console.WriteLine("\nМатрица симметрична ");
						return;
					}
				}
				symmetry++;
			}
		}
		static int MasValue()
		{
			int value;
			while (true) // Проверка на правильный ввод размера массива
			{
				string input = Console.ReadLine();
				bool check = int.TryParse(input, out value);
				if (check)
				{
					if (value <= 0)
					{
						Console.WriteLine("Значение введено не верно, попробуйте ещё раз: ");
					}
					else
						break;
				}
				else
				{
					Console.WriteLine("Значение введено не верно, попробуйте ещё раз: ");
				}
			}
			return value;
		}
		static int MasNums()
		{
			int value;
			while (true) // Проверка на правильный ввод значений массива
			{
				string input = Console.ReadLine();
				bool check = int.TryParse(input, out value);
				if (check)
				{
					if (check)
					{
						break;
					}
				}
				else
				{
					Console.WriteLine("Значение введено не верно, попробуйте ещё раз: ");
				}
			}
			return value;
		}

	}
}