using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
	    {
			string phoneNumber = "0935000046";
			string encryptedNumber=phoneNumber.Substring(0,4)+new string('*',4)+phoneNumber.Substring(9);
			Console.WriteLine(encryptedNumber);
		}
}
}
