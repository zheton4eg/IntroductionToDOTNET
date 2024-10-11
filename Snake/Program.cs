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
		private const int MapWidth = 60;
		private const int MapHeight = 40;



		private const ConsoleColor BorderColor = ConsoleColor.Red;
		private const ConsoleColor HeadColor = ConsoleColor.DarkGreen;
		private const ConsoleColor BodyColor = ConsoleColor.Green;
		static void Main(string[] args)
		{
			SetWindowSize(MapWidth, MapHeight);
			SetBufferSize(MapWidth, MapHeight);
			CursorVisible = false;
			DrawBorder();

			var snake = new Snake(initialX:10,initialY: 5, HeadColor, BodyColor);
			ReadKey();	
		}

		static void DrawBorder()
		{
			for (int i = 1; i < MapWidth - 1; i++) 
			{
				new Pixel(i,0, BorderColor).Draw();
				new Pixel(i,MapHeight-1, BorderColor).Draw();
			}
			for (int i = 1; i < MapHeight-1; i++)
			{
				new Pixel(x:0,y: i, BorderColor).Draw();
				new Pixel(MapWidth-1, y: i, BorderColor).Draw();
			}

		}
	}
}
