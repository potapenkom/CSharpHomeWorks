using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne.Dictionary
{
    public class Сandies : Product
    {
        int weight;
        public Сandies(string name, int price, int weight)
            : base(name, price)
        {
            this.weight = weight;
        }
        public int getWeight()
        {
            return weight;
        }

        public override void Display()
        {
            Console.Write($"Product name {name}, price {price} USD, weigtt {weight} kg");
        }
    }
}
