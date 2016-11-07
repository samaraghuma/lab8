using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battingaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            bool proceed = true;


            while (proceed)
            {
                Console.WriteLine("Welcome to batting average calculator");
                Console.WriteLine("enter number of times at bat: ");
                int numtime = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("result for at bat 0 : ");
                int input = Convert.ToInt32(Console.ReadLine());
                ar[0] = input;
                Console.WriteLine("result for at bat 1 : ");
                input = Convert.ToInt32(Console.ReadLine());
                ar[1] = input;

                Console.WriteLine("result for at bat 2 : ");
                input = Convert.ToInt32(Console.ReadLine());
                ar[2] = input;
                Console.WriteLine("result for at bat 3 : ");
                input = Convert.ToInt32(Console.ReadLine());
                ar[3] = input;
                Console.WriteLine("result for at bat 4 : ");
                input = Convert.ToInt32(Console.ReadLine());
                ar[4] = input;
                double slugper;
                slugper = (ar[0] + ar[1] + ar[2] + ar[3] + ar[4]);
                slugper = slugper / 5;
                Console.WriteLine("slugging percentage :  " + slugper);

                int counter = 0;
                for (int i = 0; i <= 4; i++)
                {
                    if (ar[i] != 0)
                    {
                        counter = counter + 1;
                    }
                }
                double batavg = (double)counter / 5;
                Console.WriteLine("batting average  " + batavg);
                Console.WriteLine("another batter?(y/n) ");
                string continuee = Console.ReadLine();

                if (continuee == "n")
                {
                    proceed = false;
                }


            }

        }
    }
}
