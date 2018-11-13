using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the following");
            Console.WriteLine("1) Decimal to Binary Conversion");
            Console.WriteLine("2) Binary to Decimal Conversion");
            Console.WriteLine("3) Decimal to Octal Conversion");
            Console.WriteLine("4) Octal to Decimal Conversion");
            Console.WriteLine("5) Octal to Binary Conversion");
            Console.WriteLine("6) Binary to Octal Conversion");
            Menu();


        }

        private static void Menu()
        {
            var userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                DecimalTo.Dec2Bin();
            }

            else if (userResponse == 2)
            {
                BinaryTo.Bin2Dec();
            }

            else if (userResponse == 3)
            {
                DecimalTo.Dec2Oct();
            }

            else if (userResponse == 4)
            {
                OctalTo.Oct2Dec();
            }

            else if (userResponse == 5)
            {
                OctalTo.Oct2Bin();
            }

            else if (userResponse == 6)
            {
                BinaryTo.Bin2Oct();
            }
        }

        

        
    }
}
