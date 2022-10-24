using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "Allen";
			Console.Write("請輸入值，不分大小寫:");
			string input = Console.ReadLine();
			
			if(string.IsNullOrEmpty(input))
			{
				Console.WriteLine("請輸入值");
				return;	
			}
		     if(value.ToLower()!=input.ToLower())
			{
				Console.WriteLine("不正確");
			}
			else
			{
				Console.WriteLine("正確");
			}
				
		}
	}
}
