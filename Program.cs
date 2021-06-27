using OnlineShoppingApplication.BL;
using System;

namespace OnlineShoppingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAuthorization user = new UserAuthorization();

            Console.WriteLine("|==========================================|");
            Console.WriteLine("|    Welcome to MAC Shop! Please login.    |");
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|               (1) LOGIN                  |");
            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("|New to MAC SHOP?                          |");
            Console.WriteLine("|               (2) SIGNUP                 |");
            Console.WriteLine("|                                          |");
            Console.WriteLine("|==========================================|");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.Login();
            }
            else if (userInput.Equals(2))
            {
                user.Signup();
            }
            else
            {

            }
        }
    }
}
