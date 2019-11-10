using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne.Dictionary
{
   public class Product : IProduct
    {
        protected string name;
        protected int price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
        public virtual void Display()
        {
            Console.Write($"Product name {name}, price {price}");
        }
    }
}
