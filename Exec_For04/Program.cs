using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 0;
			for (int i = 1; i <= 20; i++)
			{
				int onetotwenty = number + i;
				if (onetotwenty % 3 == 0)
				{
					Console.WriteLine("foo");
				}
				else if (onetotwenty % 5 == 0)
				{
					Console.WriteLine("bar");
				}
				else if (onetotwenty % 5 == 0 || onetotwenty % 3 == 0)
				{
					Console.WriteLine("foobar");
				}
				else
				{
					Console.WriteLine(onetotwenty);
				}
			}
		}
	}
}
