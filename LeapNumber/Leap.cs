using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapNumber
{
    internal class Leap
	{
		public static boolean leapYearCheaker(int year)
		{
			if (year > 1000)
			{
				if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
				{
					return true;
				}
			}
			return false;
		}

		public static void main(String[] args)
		{
			Utility leap = new Utility();
			System.out.println("Enter a leap year:");
			int year = leap.inputInteger();
			boolean result = leapYearCheaker(year);

			if (result)
			{
				Console.println("Year:" + year + " is a leap year");
			}
			else
			{
				Console.println("Year:" + year + " is not a leap year");

		
			}
			Sy
		}


	}
}
