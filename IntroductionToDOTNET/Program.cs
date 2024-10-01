//#define CONSOLE_CLASS
//#define STRING_OPERARIONS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static readonly string delimiter = "\n-------------------------------------\n";
		static void Main(string[] args)
		{
#if CONSOLE_CLASS
			Console.Title = "Introduction to .NET";
			Console.WriteLine("\t\t\tHello .NET");
			//Console.CursorLeft = 25;
			//Console.CursorTop = 8;
			Console.SetCursorPosition(23, 5);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Gray;

			Console.WriteLine("Привет .NET");
			Console.ResetColor();

			Console.WriteLine(delimiter);



			Console.WriteLine("Позиция окна консоли: " + Console.WindowLeft + " знакопозиций");
			Console.WriteLine("Позиция окна консоли: " + Console.WindowTop + " знакопозиций");

			Console.SetWindowSize(92, 22);

			Console.WriteLine("Ширина окна консоли: " + Console.WindowWidth + " знакопозиций");
			Console.WriteLine("Высота окна консоли: " + Console.WindowHeight + " знакопозиций");

			Console.SetBufferSize(92, 22);

			Console.WriteLine("Ширина буфера консоли: " + Console.BufferWidth + " знакопозиций");
			Console.WriteLine("Высота буфера консоли: " + Console.BufferHeight + " знакопозиций"); 
#endif
#if STRING_OPERARIONS
			Console.Write("Введите Ваше имя: ");
			string first_name = Console.ReadLine();

			Console.Write("Введтье Вашу Фамилию: ");
			string last_name = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(first_name + " " + last_name + " " + age); //Конкатенация строк
			Console.WriteLine(String.Format("{0}{1}{2}", first_name, last_name, age)); //Форматирование строк
			Console.WriteLine($"{first_name}{last_name}{age}"); //Интерполяция строк  
#endif
			Console.WriteLine("Введите размер фигуры: ");
			int size = int.Parse(Console.ReadLine());
			Console.WriteLine();
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write('#');
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = size; i >= 0; i--)
			{
				for (int j = i; j < size; j++)
				{
					Console.Write('#');
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < size; i++)
			{
				for (int j = i; j < size; j++)
				{
					Console.Write('#');
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < size; i++)
			{
				for (int h = 0; h < i; h++)
				{
					Console.Write(' ');
				}
				for (int j = i; j < size; j++)
				{
					Console.Write('#');
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = size; i >= 0; i--)
			{
				for (int h = 0; h < i; h++)
				{
					Console.Write(' ');
				}
				for (int j = i; j < size; j++)
				{
					Console.Write('#');
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			/*
						//1 половина верха
						for (int i = 0; i < size; i++)
						{
							for (int j = i; j < size-1; j++)
							{
								Console.Write(' ');
							}
							Console.Write('/');

							Console.WriteLine();
						}
						//1 половина низа
						for (int i = size-1; i >= 0; i--)
						{
							for (int j = i; j < size-1; j++)
							{
								Console.Write(' ');
							}
							Console.Write('\\');
							Console.WriteLine();

						}*/
			Console.WriteLine(delimiter);
			for (int i = 0; i < size * 2; i++)
			{
				for (int j = 0; j < size * 2; j++)
				{
					if (i + size == j || j + size == i) Console.Write('\\');
					if (size - 1 - j % size == i % size && i + j + 1 != size * 2) Console.Write('/');
					else Console.Write(' ');
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if ((i + j) % 2 == 0) Console.Write("+");
					else Console.Write("-");
				}
				Console.WriteLine();
			}
		}
	}
}