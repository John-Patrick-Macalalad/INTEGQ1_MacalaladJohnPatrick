using System;

namespace OnlineShoppingApplication.DL
{
    public class Product
    {
        public string keyboardBrand;
        private string price;
        private DateTime date;

        public Product(string keyboardBrand, string price, DateTime date)
        {
            this.keyboardBrand = keyboardBrand;
            this.price = price;
            this.date = date;
        }

        public string KeyboardBrand
        {
            get { return keyboardBrand; }
            set { keyboardBrand = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
