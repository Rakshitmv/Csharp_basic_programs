using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    internal class Coin
    {
        double head = 0;
        double tail = 0;

        public void heads()
        {
            Console.WriteLine("Enter the no of times the coin is tossed");
            int repeat = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < repeat; i++)
            {

                double rand = random.NextDouble();
                Console.WriteLine(rand + " ");
                if (rand < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            double percentage = (head / repeat) * 100;
            Console.WriteLine("Percentage of getting head is :" + percentage );
            Console.WriteLine("Percentage of getting tail is :" + (100 - percentage) );
            Console.ReadKey();

        }
    }
}
