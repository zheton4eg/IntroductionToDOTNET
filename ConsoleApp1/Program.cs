#define ARRAYS_1
#define ARRAYS_2
//#define JAGGED_ARRAY
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.WriteLine("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rand = new Random(0);


			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			//поиск наименьшего элемента массива
			for (int i = 1; i < arr.Length; i++)
				{
					int buffer = arr[0];
					if (arr[0] > arr[i])
					{
						arr[0] = arr[i];
						arr[i] = buffer;
					}
				}
			Console.WriteLine($"наименьший элемент массива: {arr[0]}");

			             //поиск наименьшего элемента массива
			for (int i = 1; i < arr.Length; i++)
			{
				int buffer = arr[0];
				if (arr[0] < arr[i])
				{
					arr[0] = arr[i];
					arr[i] = buffer;
				}
			}
			Console.WriteLine($"Наибольний элемент массива: {arr[0]}");

			            //поиск среднего арифметического массива
			double resoult = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				resoult += arr[i];					
			}
			Console.WriteLine($"Сумма элементов массива{resoult}");
			Console.WriteLine($"среднее арифметическое массива{resoult/n}");

			//Сортировка массива

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i; j < arr.Length; j++)
				{
					int buffer = arr[j];
					if (arr[j] > arr[i])
					{
						arr[j] = arr[i];
						arr[i] = buffer;
					}
				}
			}
			//Вывод массива в обратном порядке
			Console.Write("\tСортировка и вывод массива в обратном порядке:\t");
			for (int i = arr.Length-1; i >= 0; i--)
			{
				Console.Write(arr[i] + "\t");
			}

			/*Console.WriteLine();
			foreach (int i in arr)
			{
				Console.Write(i+"\t");
			}
			Console.WriteLine();*/
#endif
#if ARRAYS_2

			Console.WriteLine("Введите кол-во строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите кол-во элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];
			
			Console.WriteLine(i_arr_2.Rank);

			Random random = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = random.Next(100);	
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i,j] + "\t");
				}
				Console.WriteLine();	
			}
			Console.WriteLine();
			
			//Сортировка массива:
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(0); j++)
				{

					for (int k = j; k < i_arr_2.GetLength(1)-1; k++)
					{
						
							int buffer = i_arr_2[i, k + 1];
							if (i_arr_2[i, k + 1] > i_arr_2[i, j])
							{
								i_arr_2[i, k + 1] = i_arr_2[i, j];
								i_arr_2[i, j] = buffer;
							}
						
					}
					
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			/*foreach (int i in i_arr_2)
				{
					Console.Write(i + "\t");
				}
				Console.WriteLine("\t");*/
#endif
#if JAGGED_ARRAY
			int[][] arr_jagged = new int[][]
				{
				new int[]{0,1,1,2 },
				new int[]{3,5,8,13 },
				new int[]{34,55,89},
				new int[]{144,233,377,610,987},
				};

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine(); 
				}
#endif

		}
		}
}
