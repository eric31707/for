using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入階乘數量");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}
			int number = Convert.ToInt32(input);
			for (int i = 1; i <= number; i++)
			{
				int countofplus = number - i;
				string row = new string('+', countofplus);
				for (int k = number; k > 0; k--)
				{
					if (row.Length < number)
					{
						row += i.ToString();
					}
				}
				Console.WriteLine(row);
			}
			//int number = 5;
			//for (int i = 1; i <= number; i++)
			//{
			//	for (int k = 1; k <=i; k++)
			//	{
			//		Console.Write(i);
			//	}
			//	Console.WriteLine();
			//}
			//for (int j = 4; j > 0; j--)
			//{
			//	int numbers = 0;
			//	numbers++;
			//	int line = numbers;
			//	Console.WriteLine(new string('+', j));
			//}
		}
	}
}




