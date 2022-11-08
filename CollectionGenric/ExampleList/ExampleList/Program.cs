using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val;
            int num;
            List<string> food = new List<string>();

            food.Add("Pizza");
            food.Add("Pasta");
            food.Add("Hotdog");
            food.Add("burger");
            food.Add("fries");

            Console.WriteLine("Original List Items");
            Console.WriteLine("===================");

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
                Console.WriteLine();
               
                

            while (food.Count > 0)
            {
                Console.WriteLine("Enter 1 for Add New Item in List");
                Console.WriteLine("Enter 2 for Remove Item From List");
                Console.WriteLine("Enter 3 for Count the Items In List");
                Console.WriteLine("Enter 4 for Sort the List");
                Console.WriteLine("Enter 5 for Display the Items In List");
                Console.WriteLine("Enter 6 for Find the Index of a Item In List");
                Console.WriteLine("Enter 7 for Find the Item In List");
                Console.WriteLine();
                val = Console.ReadLine();
                num = Convert.ToInt32(val);


                if (num == 1)
                {
                    Console.WriteLine("Enter Item Name");
                    string newItem = Console.ReadLine();
                    food.Add(newItem);
                    Console.WriteLine(newItem + " Item added In Your List");
                    Console.WriteLine();
                }
                else if (num == 2)
                {
                    Console.WriteLine("Enter Item Name You Want To Remove From List");
                    string ItemName = Console.ReadLine();
                    food.Remove(ItemName);
                    Console.WriteLine(ItemName + " Item Removed From List");
                    Console.WriteLine();
                }
                else if (num == 3)
                {
                    Console.WriteLine("Total Numbers of Items In Your List");
                    Console.WriteLine(food.Count);
                    Console.WriteLine();
                }
                else if(num == 4)
                {
                    Console.WriteLine("Sorted List");
                    food.Sort();
                    foreach (string item in food)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                }
                else if (num == 5)
                {
                    Console.WriteLine("Items In Your List");
                    foreach (string item in food)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();

                }
                else if(num == 6)
                {
                    Console.WriteLine("Enter Item Name You Want To Check the Index in List");
                    string ItemName = Console.ReadLine();
                    Console.WriteLine(ItemName + " Is at Index " + food.IndexOf(ItemName));
                    Console.WriteLine();
                }
                else if(num == 7)
                {
                    Console.WriteLine("Enter Item Name You Want To Find in List");
                    string ItemName = Console.ReadLine();                  
                    if(food.Contains(ItemName) == true)
                    {
                        Console.WriteLine("Yes it is at Index "+ food.IndexOf(ItemName));
                    }
                    else
                    {
                        Console.WriteLine("No Item Found");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
            Console.ReadKey();
        }
    }
}
