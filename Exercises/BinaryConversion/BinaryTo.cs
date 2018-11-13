using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    class BinaryTo
    {
        public static void Bin2Dec()
        {
            Console.WriteLine("Enter a valid Binary number using 1s and 0s");
            int BNum = Convert.ToInt32(Console.ReadLine());
            var BNumSum = 0;

            for (int i = 0; BNum != 0; i++)
            {
                BNumSum += ((int)Math.Pow(2, i)) * (BNum % 10);
                BNum = BNum / 10;
            }

            BNumSum.ToString();
            Console.WriteLine($"Decimal Conversion: {BNumSum}");

        }

        public static void Bin2Oct()
        {
            Console.WriteLine("Enter a valid Binary number using 1s and 0s");
            int BNum = Convert.ToInt32(Console.ReadLine());
            string v = "";

            while (BNum != 0)
            {
                int BNum2 = BNum % 1000;
                int Temp = 0;
                for (int i = 0; i < 3; i++)
                {
                    Temp += (BNum2 % 10) * ((int)Math.Pow(2, i));
                    BNum2 = BNum2 / 10;
                }
                v = string.Format($"{Temp}{v}");
                BNum = BNum / 1000;
            }

            Console.WriteLine($"Binary to Octal Conversion: {v}");
        }
    }
}
