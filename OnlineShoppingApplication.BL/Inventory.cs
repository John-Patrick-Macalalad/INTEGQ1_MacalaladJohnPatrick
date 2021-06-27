using OnlineShoppingApplication.DL;
using System;
using System.Collections.Generic;
using System;

namespace OnlineShoppingApplication.BL
{
    public class Inventory
    {
        public List<Product> ProductInfo = new List<Product>()
        {
            new Product ("A4Tech","P400", new DateTime(2021,6,7)),
            new Product ("Razer","P5000", new DateTime(2021,6,13)),
            new Product ("Logitech","P1400", new DateTime(2021,6,19)),
            new Product ("HyperX","P4500", new DateTime(2021,6,27)),
            new Product ("Corsair","P5800", new DateTime(2021,6,27)),
        };

        public void ProductView()
        {
            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nKeyboard Brand:{0}| \nPrice: {1}| \nDate: {2}", product.KeyboardBrand, product.Price, product.Date);
            }
        }
        public void ProductAdd()
        {
            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nKeyboard Brand:{0}| \nPrice: {1}| \nDate Time:{2}", product.KeyboardBrand, product.Price, product.Date);
            }

            Console.WriteLine("Enter Keyboard Brand: ");
            string addProduct = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            string addPrice = Console.ReadLine();
            DateTime addDate = DateTime.Now;


            ProductInfo.Add(new Product(addProduct, addPrice, addDate));
            Console.WriteLine("\nKeyboard brand:{0}| \nPrice:${1}| \nDate: {2}| \nProduct Successfully Added :)", addProduct, addPrice, addDate);

            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nKeyboard Brand:{0}| \nPrice: {1}| \nDate:{2}", product.KeyboardBrand, product.Price, product.Date);
            }
        }
        public void ProductRemoved()
        {
            Console.WriteLine("Enter Index Position:");
            int indexPosition = int.Parse(Console.ReadLine());

            ProductInfo.RemoveAt(indexPosition);

            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nKeyboard Brand:{0}| \nPrice: {1}| \nDate:{2}", product.KeyboardBrand, product.Price, product.Date);
            }
        }
    }
}
