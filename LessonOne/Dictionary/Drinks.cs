using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOne.Dictionary
{
   public class Drinks : Product
    {
        int volume;
        public Drinks(string name, int price, int volume)
            : base(name, price)
        {
            this.volume = volume;
        }
        public int getVolume()
        {
            return volume;
        }
        public override void Display()
        {
            Console.Write($"Product name {name}, price {price} USD, volume {volume} liters");
        }
    }
}
