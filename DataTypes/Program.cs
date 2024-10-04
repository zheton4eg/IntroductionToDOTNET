using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimiter = "\n-----------------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine("Hello DataTypes");
			/*	Console.WriteLine(sizeof(bool));
				Console.WriteLine(true);
				Console.WriteLine(false);
				Console.WriteLine(Boolean.FalseString);*/

			//Console.WriteLine(sizeof(char));   //Unicode
			//Console.WriteLine('+'.GetType());
			/*
            --------------------------------------
			              unsigned:
			  byte;        sbyte;    1 byte
			  short;       ushort;   2 byte
			  int;         uint;     4 byte
			  long;        ulong;    8 byte
			--------------------------------------                                    */
			Console.WriteLine("Byte: ");
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("SByte: ");
			Console.WriteLine(sizeof(sbyte));
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);

			
		}
	}
}
