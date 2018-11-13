using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    class DecimalTo
    {
        public static void Dec2Bin()
        {
            Console.WriteLine("Enter a valid decimal number");
            int number = Convert.ToInt32(Console.ReadLine());

            string v = "";

            while (number != 0)
            {
                v = string.Format($"{number % 2}{v}");
                number = number / 2;
            }
            Console.WriteLine($"Binary Conversion: {v}");
        }

        public static void Dec2Oct()
        {
            Console.WriteLine("Enter a valid Octal number");
            int number = Convert.ToInt32(Console.ReadLine());

            string v = "";

            while (number != 0)
            {
                v = string.Format($"{number % 8}{v}");
                number = number / 8;
            }
            Console.WriteLine($"Octal Conversion: {v}");
        }
    }
}
