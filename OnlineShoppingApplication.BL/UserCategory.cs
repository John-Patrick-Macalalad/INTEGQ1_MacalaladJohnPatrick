using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingApplication.BL
{
    public class UserCategory
    {
        public void Category()
        {
            Inventory productServices = new Inventory();

        START:
            Console.WriteLine("|==========================================|");
            Console.WriteLine("|           (1) View a Product             |");
            Console.WriteLine("|           (2) Add a Product              |");
            Console.WriteLine("|           (3) Remove a Product           |");
            Console.WriteLine("|           (4) Exit                       |");
            Console.WriteLine("|==========================================|");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    productServices.ProductView();
                    goto START;
                case 2:
                    productServices.ProductAdd();
                    goto START;
                case 3:
                    productServices.ProductRemoved();
                    goto START;

                default:
                    break;
            }

        }
    }
}
