using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Snake
{
	internal class Program
	{
		private const int MapWidth = 30;
		private const int MapHeight = 20;



		private const ConsoleColor BorderColor = ConsoleColor.Red;
		static void Main(string[] args)
		{
			SetWindowSize(MapWidth, MapHeight);
			SetBufferSize(MapWidth, MapHeight);
			CursorVisible = false;
			DrawBorder();
			ReadKey();	
		}

		static void DrawBorder()
		{
			for (int i = 0; i < MapWidth; i++) 
			{
				new Pixel(i,0, BorderColor).Draw();
				new Pixel(i,MapHeight-1, BorderColor).Draw();
			}
			for (int i = 0; i < MapHeight; i++)
			{
				new Pixel(0,  i, BorderColor).Draw();
				new Pixel(MapWidth-1,  i, BorderColor).Draw();
			}

		}
	}
}
