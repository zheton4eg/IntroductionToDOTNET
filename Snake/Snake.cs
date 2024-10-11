using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Snake
	{
		private readonly ConsoleColor _headColor;
		private readonly ConsoleColor _bodyColor;
		public Snake(int initialX, int initialY, ConsoleColor headColor, ConsoleColor bodyColor, int bodyLength = 2)
		{
			_headColor = headColor;
			_headColor = bodyColor;

			Head = new Pixel(initialX, initialY, headColor);
			for (int i = bodyLength; i >= 0; i--)
			{
				Body.Enqueue(item: new Pixel(x: Head.X - i - 1, initialY, bodyColor));
			}
			Draw();
		}
		public Pixel Head { get; private set; }
		public Queue<Pixel> Body { get; } = new Queue<Pixel>();

		public void Move(Direction direction)
		{
			Clear();
			Body.Enqueue(new Pixel(Head.X, Head.Y, _bodyColor));
			Body.Dequeue();
		
			Draw();
			}
		public void Draw()
		{
			foreach (Pixel pixel in Body)
			{
pixel.Draw();

			}
		}
		public void Clear()
		{
			Head.Clear();
			foreach (Pixel pixel in Body)
			{
				pixel.Clear();

			}
		}
	}
}
