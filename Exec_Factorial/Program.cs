using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入階乘");
			string input = Console.ReadLine();
			int sum=1;
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("你沒有輸入");
				return;
			}			
			for (int i = 1; i <=Convert.ToInt32(input); i++)
			{
				sum *= i;
			}
			Console.WriteLine(sum);
		}
	}
}
