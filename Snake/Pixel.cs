using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	public readonly struct Pixel
	{
		private const char PixelChar = '█';

		public Pixel(int x, int y, ConsoleColor color, int pixelSize=3)
		{
			X = x;
			Y = y;
			Color = color;
			PixelSize=pixelSize;
		}
		
		public int X { get; }
		public int Y { get; }

		public ConsoleColor Color { get; }
		public int PixelSize { get; }

		public void Draw()
		{
			for (int x = 0; x < PixelSize; x++)
			{
				for (int y = 0; y < PixelSize; y++)
				{
					Console.SetCursorPosition(X,Y);
					Console.Write(PixelChar);
				}
			}	
		}
		public void Clear()
		{
			Console.SetCursorPosition(left:X,top:Y);
			Console.Write(' ');
		}
	}
}

