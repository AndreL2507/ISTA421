using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingandDecoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Encode a phrase with a single character key");
            Console.WriteLine("2. Encode a phrase with a multi-character key");
            Console.WriteLine("3. Encode a phrase with a key + the rest of your phrase");
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine();
            int userresponse = Convert.ToInt32(Console.ReadLine());

            if (userresponse == 1)
            {
                Console.WriteLine("Enter a phrase to encrypt:");
                string userphrase = Console.ReadLine();
                userphrase = toClean(userphrase);

                START:
                Console.WriteLine("Enter a one character key:");
                string key = Console.ReadLine();
                if (key.Length > 1)
                {
                    Console.WriteLine("Sorry, that key is too long. Enter only 1 character");
                    goto START; 
                }

                key = toClean(key);

                Console.WriteLine(userphrase);
                Console.WriteLine(key);
                string encoded = Encode1(userphrase, key);
                string decoded = Decode1(encoded, key);
                Console.WriteLine($"Encoded Phrase: {encoded}");
                Console.WriteLine($"Decoded Phrase: {decoded}");
 
            }

            else if (userresponse == 2)
            {
                Console.WriteLine("Enter a phrase to encrypt:");
                string userphrase = Console.ReadLine();
                userphrase = toClean(userphrase);
                Console.WriteLine("Enter a multi-character key:");
                string key = Console.ReadLine();
                key = toClean(key);
                string encoded = Encode2(userphrase, key);
                string decoded = Decode2(encoded, key);
                Console.WriteLine($"Encoded Phrase: {encoded}");
                Console.WriteLine($"Decoded Phrase: {decoded}");
            }
            else if (userresponse == 3)
            {
                Console.WriteLine("Enter a phrase to encrypt:");
                string userphrase = Console.ReadLine();
                userphrase = toClean(userphrase);
                Console.WriteLine("Enter a multi-character key:");
                string firstkey = Console.ReadLine();
                firstkey = toClean(firstkey);
                string key = firstkey + userphrase;
                Console.WriteLine(key);
                string encoded = Encode2(userphrase, key);
                string decoded = Decode2(encoded, key);
                Console.WriteLine($"Encoded Phrase: {encoded}");
                Console.WriteLine($"Decoded Phrase: {decoded}");

            }

        }

        private static string Decode2(string encoded, string key)
        {
            StringBuilder decoded = new StringBuilder();
            for (int i = 0; i < encoded.Length; i++)
            {
                int keyshift = (int)key[i % key.Length] - 64;

                if ((int)encoded[i] - keyshift < 64)
                {
                    char cc = (char)(((int)encoded[i] - keyshift) + 26);
                    decoded.Append(cc);
                }
                else if ((int)encoded[i] - keyshift > 64 && (int)encoded[i] - keyshift < 92)
                {
                    char cc = (char)(encoded[i] - keyshift);
                    decoded.Append(cc);
                }
            }
            return decoded.ToString();
        }

        private static string Decode1(string encoded, string key)
        {
            int keyshift = (int)key[0] - 64;
            Console.WriteLine($"Decode Keyshift: - {keyshift}");
            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < encoded.Length; i++)
            {

                if ((int)encoded[i] - keyshift < 64)
                {
                    char cc = (char)(((int)encoded[i] - keyshift) + 26);
                    decoded.Append(cc);
                }
                else if ((int)encoded[i] - keyshift > 64 && (int)encoded[i] - keyshift < 92)
                {
                    char cc = (char)(encoded[i] - keyshift);
                    decoded.Append(cc);
                }


            }
            return decoded.ToString();
        }

        private static string Encode2(string userphrase, string key)
        {
            StringBuilder encoded = new StringBuilder();
            for(int i = 0; i < userphrase.Length; i++)
            {
                int keyshift = (int)key[i % key.Length] - 64;

                if ((int)userphrase[i] + keyshift > 92)
                {
                    char cc = (char)((int)userphrase[i] + keyshift - 26);
                    encoded.Append(cc);
                }
                else if ((int)userphrase[i] + keyshift > 64 && (int)userphrase[i] + keyshift < 92)
                {
                    char cc = (char)(userphrase[i] + keyshift);
                    encoded.Append(cc);
                }
            }
            return encoded.ToString();
        }

        private static string Encode1(string userphrase, string key)
        {
            int keyshift = (int)key[0] - 64;
            Console.WriteLine($"Encode Keyshift: + {keyshift}");
            StringBuilder encoded = new StringBuilder();

            for (int i = 0; i < userphrase.Length; i++)
            {

                if ((int)userphrase[i] + keyshift > 92)
                {
                    char cc = (char)((int)userphrase[i] + keyshift - 26);
                    encoded.Append(cc);
                }
                else if ((int)userphrase[i] + keyshift > 64 && (int)userphrase[i] + keyshift < 92)
                {
                    char cc = (char)(userphrase[i] + keyshift);
                    encoded.Append(cc);
                }
                    

            }
            return encoded.ToString();
           
        }

        private static string toClean(string v)
        {
            StringBuilder clean = new StringBuilder();

            for (int i = 0; i < v.Length; i++)
            {
                if ((int)v[i] > 64 && (int)v[i] < 92)
                {
                    char cc = (char)v[i];
                    clean.Append(cc);

                }
                else if ((int)v[i] > 96 && (int)v[i] < 123)
                {
                    char cc = (char)(v[i] - 32);
                    clean.Append(cc);

                }
                else
                    continue;
            }
            return clean.ToString();
        }
    }
}
