using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    class OctalTo
    {
        public static void Oct2Dec()
        {
            Console.WriteLine("Enter a valid Octal number");
            int ONum = Convert.ToInt32(Console.ReadLine());
            var ONumSum = 0;

            for (int i = 0; ONum != 0; i++)
            {
                ONumSum += ((int)Math.Pow(8, i)) * (ONum % 10);
                ONum = ONum / 10;
            }

            ONumSum.ToString();
            Console.WriteLine($"Decimal Conversion: {ONumSum}");
        }

        public static void Oct2Bin()
        {
            Console.WriteLine("Enter a valid Octal number");
            int ONum = Convert.ToInt32(Console.ReadLine());
            var ONumSum = 0;

            for (int i = 0; ONum != 0; i++)
            {
                ONumSum += ((int)Math.Pow(8, i)) * (ONum % 10);
                ONum = ONum / 10;
            }

            int toconvert = ONumSum;
            string v = "";

            while (toconvert != 0)
            {
                v = string.Format($"{toconvert % 2}{v}");
                toconvert = toconvert / 2;
            }
            Console.WriteLine($"Binary Conversion: {v}");
        }
    }
}
