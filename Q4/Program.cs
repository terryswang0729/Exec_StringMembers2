using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string value = "110/02/25";
			//DateTime taiwanYear=Convert.ToDateTime(value);
			//DateTime adYear = taiwanYear.AddYears(1911);
			//Console.WriteLine(adYear);

			string sampleYear = "1100225";
			int adYear = Convert.ToInt32((sampleYear.Substring(0, 3)))+1911;
			DateTime result = new DateTime(adYear, 02, 25);
			string anwser=result.ToString("yyyy,02,25");
			Console.WriteLine(anwser);
		}
	}	
}
