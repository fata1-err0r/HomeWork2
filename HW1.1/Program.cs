using System;

namespace HW1._1        // сложность алгоритма - Квадратичный O(n*log(n))
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер массива ");
			int arraySize = MasValue();
			int[] mas = new int[arraySize];
			Console.WriteLine("Введите данные массива в порядке увеличения ");
			for (int i = 0; i < mas.Length; i++) // цикл для ввода значений массива
			{
				Console.Write($"{i + 1} значение массива: ");
				mas[i] = MasNums();
			}
			Console.WriteLine("Ваш массив: ");
			for (int i = 0; i < mas.Length; i++) // Цикл для вывода массива в консоль
			{
				Console.Write($"{mas[i]} ");
			}
			int count = 1; // подсчет уникальных цифр
			for (int a = 0; a < mas.Length - 1; a++)
			{
				for (int b = a + 1; b < mas.Length; b++)
				{
					if (mas[a] == mas[b])
						break;

					if (b == mas.Length - 1)
						count++;
				}
			}
			Console.WriteLine($"\nВ массиве найдено {count} разных чисел ");
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
			while (true) // Проверка на ввод значений массива
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
