using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightMostDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1;
            int int2;
            int int3;

            Console.WriteLine("Enter three numbers: ");
            int1 = Convert.ToInt32(Console.ReadLine());
            int2 = Convert.ToInt32(Console.ReadLine());
            int3 = Convert.ToInt32(Console.ReadLine());

            if (int1 %10 == int2%10 && int2%10 == int3%10)
            {
                Console.WriteLine("All numbers have the same right digit.");
            }
            else if (int1 % 10 == int2 % 10 || int2 % 10 == int3 % 10 || int3%10 == int1%10)
            {
                Console.WriteLine("Two numbers have the same right digit.");
            }

            else
            {
                Console.WriteLine("No numbers have the same right digit.");
            }
            Console.ReadLine();
        }
    }
}
