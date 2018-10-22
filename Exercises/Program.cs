using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9Encryption
{
    class Program
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        static string username { get; set; }
        static string password { get; set; }
        static void Main()
        {
            // implement option to 1) input username and password, 2) authenticate, 3) Exit and delete all data

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1) Create a new Account");
            Console.WriteLine("2) Authenticate Account");
            Console.WriteLine("3) Exit the Program");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------");
            
            Menu();


        }

        private static void Menu()
        {
            int userResponse = Convert.ToInt32(Console.ReadLine());

            if (userResponse == 1)
            {
                getNewUser();
            }

            if (userResponse == 2)
            {
                authenticateUser();
            }

            if (userResponse == 3)
            {
                ExitProgram();
            }

            else if (userResponse > 3)
            {
                Console.WriteLine("Invalid Entry, try again");
                Menu();
            }
        }

        private static void ExitProgram()
        {
           foreach (KeyValuePair<string, string> user in users)
            {
                Console.WriteLine(user);
            }
        }

        private static void authenticateUser()
        {
            Console.WriteLine("Enter Your Username and Password");
            START2:
            Console.WriteLine("Username: ");
            username = Console.ReadLine();


            if (users.ContainsKey(username))
            {
                START:
                if (users.ContainsValue(HashPassword().ToString()))
                {
                    Console.WriteLine("\nUser Authenticated");
                    Main();
                }

                else
                {
                    Console.WriteLine("\nIncorrect Password");
                    goto START;
                }
 
            }


            else if (users.ContainsKey(username) == false )
            {
                Console.WriteLine("\nThat User does not exist");
                goto START2;
            }
           

        }

        private static void getNewUser()
        {
            Console.WriteLine("Enter a Username");
            START: 
            username = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                Console.WriteLine("Sorry, that Username is unavailable");
                Console.WriteLine("Please try another Username");
                goto START;
            }
            users.Add(username, HashPassword().ToString());
            Console.WriteLine("\n You have created a new Account \n");
            Main();
       
        }

        private static object HashPassword()
        {
            Console.WriteLine("Please enter a password.");

            password = Console.ReadLine();

            MD5 md5 = MD5.Create();

            byte[] encodedPassword = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder hashedPassword = new StringBuilder();

            for (int i = 0; i < encodedPassword.Length; i++)

            {

                hashedPassword.Append(encodedPassword[i].ToString("x2"));

            }

            return hashedPassword.ToString();
        }

    }
}
