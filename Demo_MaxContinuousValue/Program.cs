using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入0或是3用逗點區隔");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}
			string[] words = input.Split(',');
			int result = 0;
			int number = 0;
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i] == "3")
				{
					number += 3;
				}
				else
				{
					if (result < number)
					{
						result = number;
						number = 0;
					}
				}
			}
			if (result < number)
			{
				result = number;
				number = 0;
			}
			Console.WriteLine(result);
		}
	}
}
