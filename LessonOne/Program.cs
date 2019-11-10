using System;
using System.Collections.Generic;
using LessonOne.Dictionary;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayLst.ShowArrayList();
            Console.WriteLine();
            MyHashTable.ShowHashTable();
            Console.WriteLine();
            MyQueue.ShowQueue();
            Console.WriteLine();
            MyStack.ShowStack();
            Console.WriteLine();
            MyList.ShowList();
            Console.WriteLine();
            GenericStack.ShowGenericStack();
            Console.WriteLine();
            GenericQueue.ShowGenericQueue();

            Dictionary<INum, IProduct> candies = new Dictionary<INum, IProduct>();
            candies.Add(new Num(1), new Сandies("Wispa Gold", 170, 2));
            candies.Add(new Num(2), new Сandies("Ferrero Rocher", 70, 2));
            candies.Add(new Num(3), new Сandies("Fritz Knipschildt", 40, 2));

            foreach (KeyValuePair<INum, IProduct> keyValue in candies)
            {

                Console.WriteLine($"{keyValue.Key.getNum()} - {keyValue.Value.getName()}");
            }
            Console.WriteLine();
            Dictionary<INum, IProduct> drink = new Dictionary<INum, IProduct>();
            drink.Add(new Num(1), new Drinks("Juice", 7, 1));
            drink.Add(new Num(2), new Drinks("Pepsi", 5, 2));
            drink.Add(new Num(3), new Drinks("Milk", 10, 1));

            foreach (KeyValuePair<INum, IProduct> keyValue in drink)
            {
                Console.WriteLine($"{keyValue.Key.getNum()} - {keyValue.Value.getName()}");
            }

            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            numbers.AddLast(5);
            numbers.AddLast(6);
            numbers.AddLast(7);
            numbers.AddLast(8);
            numbers.AddLast(9);
            numbers.AddLast(10);
            Console.WriteLine("Initial list");

            foreach (int item in numbers)
            {
                Console.WriteLine($"Element LinkedList- {item}");
            }
            LinkedListNode<int> currentNode = numbers.First;
            int middle = numbers.Count / 2;
            int index = 1;
            while (currentNode != null)
            {
                currentNode = currentNode.Next;
                if (index == middle)
                {
                    numbers.Remove(currentNode);
                }
                index += 1;
            }
            foreach (int i in numbers)
            {
                Console.WriteLine($"LinkedList after- {i}");
            }
        }
    }
}
