using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//double a, b;
			//char s;
			//while (true)
			//{
			//	Console.Write("Введите выражение через ENTER: ");
			//	a = double.Parse(Console.ReadLine());
			//	s = char.Parse(Console.ReadLine());
			//	b = double.Parse(Console.ReadLine());
			//	switch (s)
			//	{
			//		case '+':
			//			Console.Write($"{a} + {b} = ");
			//			Console.WriteLine(a + b);break;
			//		case '-':
			//			Console.Write($"{a} - {b} = ");
			//			Console.WriteLine(a - b); break;
			//		case '*':
			//			Console.Write($"{a} * {b} = ");
			//			Console.WriteLine(a * b); break;
			//		case '/':
			//			Console.Write($"{a} / {b} = ");
			//			Console.WriteLine(a / b); break;
			//		default:
			//			Console.WriteLine("Ошибка, попробуйте снова!");
			//			continue;
			//	}
			//}



			Console.WriteLine("Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
			expression=expression.Replace('.',',');//Метод Replace за
			//string[] numbers = expression.Split('+', '-', '*', '/');
			char[] delimiters = new char[]{'+', '-', '*', '/'};
			string[] numbers = expression.Split(delimiters);
			try
			{
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);
				#region Ifcalc
				/*if (expression.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
				else if (expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
				else if (expression.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");
				else if (expression.Contains("/")) Console.WriteLine($"{a} / {b} = {a / b}"); */
				#endregion

				#region SwitchCalc
				switch (expression[expression.IndexOfAny(delimiters)])
				{
					case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
					case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
					case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
					case '/': Console.WriteLine($"{a} / {b} = {a / b}"); break;
						default: Console.WriteLine("Error: No Operation");break; //не работает
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			} 
			#endregion
			Main(args);
		}
	}
}
