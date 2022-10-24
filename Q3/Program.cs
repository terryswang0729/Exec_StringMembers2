using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "aLLEN kUO";
			string result = value.ToLower();
			string firstNameFirstWord=result.Substring(0,1).ToUpper()+result.Substring(1,4);
			string lastNameFirstWord=result.Substring(6,1).ToUpper()+result.Substring(7);
			string anwser=$"{firstNameFirstWord}{" "}{lastNameFirstWord}";
			Console.WriteLine(anwser);
		}
	}
}
