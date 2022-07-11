using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            double n = double.Parse(Console.ReadLine());
           

            for(int i = 1111; i <= 9999; i++)
            {
                int br = 0;
                for (int j = i; j > 0; j = j / 10)
                {
                   
                    if (n % (j % 10)==0)
                    {
                        br++;
                    }
                }

                if (br == 4)
                {
                    Console.Write("{0} ", i);
                }
                
            }

            Console.ReadLine();
        }
    }
}
