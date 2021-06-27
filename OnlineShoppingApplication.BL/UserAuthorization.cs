using OnlineShoppingApplication.DL;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingApplication.BL
{
    public class UserAuthorization
    {
        public List<User> UserCredentials = new List<User>()
        {
            new User("MACSHOP","2021")
        };

        public void Login()
        {
            UserCategory catalogue = new UserCategory();
            bool successful = false;
            Console.WriteLine("");
            Console.WriteLine("Enter UserName:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter PassWord:");
            string passWord = Console.ReadLine();

            foreach (User user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Logged in Successfully!!");
                    successful = true;
                    catalogue.Category();
                }
            }
            if (!successful)
            {
                Console.WriteLine(" ! LOGIN FAILED ! ");
            }
        }
        public void Signup()
        {
            Console.WriteLine("Enter UserName: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter PassWord: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new User(userName, passWord));
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|         REGISTERED SUCCESSFULLY!!!       |");
            Console.WriteLine("|==========================================|");

            foreach (User user in UserCredentials)
            {
                Console.WriteLine("Username:{0}, Password:{1}", user.UserName, user.PassWord);
            }

        }
    }
}
