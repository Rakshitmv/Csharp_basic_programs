using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1: To select CoinToss\n" + "Enter 2: To find Nth Harmonic number\n" + "Enter 3: Exit\n");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Coin percent = new Coin();
                        percent.heads();
                        break;
                    case 2:
                        HarmonicNumber numbers = new HarmonicNumber();
                        numbers.Harmonic();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
