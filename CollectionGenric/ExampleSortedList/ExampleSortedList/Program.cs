using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> StateName = new SortedList<string, string>(StringComparer.OrdinalIgnoreCase);
                         //State      Capital
            StateName.Add("Himachal", "Shimla");
            StateName.Add("Punjab", "Chandigarh");
            StateName.Add("Bihar", "Patna");
            StateName.Add("Haryana", "Chandigarh");
            StateName.Add("Jharkhand", "Ranchi");
            StateName.Add("Karnataka", "Bengaluru");
            StateName.Add("Madhya Pradesh", "Bhopal");
            StateName.Add("Uttarakhand", "Dehradun ");
            StateName.Add("West Bengal", "Kolkata");

            Console.WriteLine("State         Capital");
            Console.WriteLine("================================");
            foreach (var key in StateName)
            {
                Console.WriteLine("State: {0}, Capital: {1}", key.Key, key.Value);
            }
            Console.WriteLine();

            while (StateName.Count > 0)
            { 
                Console.WriteLine("Enter 1 for add new Capital");
                Console.WriteLine("Enter 2 for remove Capital");
                Console.WriteLine("Enter 3 for to check the Capacity of StateName List");
                Console.WriteLine("Enter 4 for to check the Count of StateName List");
                Console.WriteLine("Enter 5 for Display Capitals");
                Console.WriteLine("Enter 6 for Display All Details");
                Console.WriteLine("Enter 7 for Clear list");
                Console.WriteLine();
                Console.WriteLine("Enter Your Choice");
                string Choice = Console.ReadLine();
                int Num = Convert.ToInt32(Choice);
                Console.WriteLine();
                if (Num == 1)
                {
                    Console.WriteLine("Enter the State Name As A Key");
                    string KeyName = Console.ReadLine();
                    if (StateName.ContainsKey(KeyName))
                    {
                        Console.WriteLine("Key Already Exist");
                    }
                    else
                    {
                        Console.WriteLine("Enter the Capital");
                        string Capital = Console.ReadLine();

                        Console.WriteLine();
                        StateName.Add(KeyName, Capital);
                        Console.WriteLine("Capital " + Capital + " Added In List");
                    }

                    Console.WriteLine();
                }
                else if (Num == 2)
                {
                    Console.WriteLine("Enter the Key To Remove Capital");
                    string KeyName = Console.ReadLine();
                    if (StateName.ContainsKey(KeyName))
                    {
                        StateName.Remove(KeyName);
                        Console.WriteLine(KeyName + "Removed From List");

                        Console.WriteLine();
                        foreach (var key in StateName)
                        {
                            Console.WriteLine("State: {0}, Capital: {1}", key.Key, key.Value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Key Not Found");
                    }
                    Console.WriteLine();
                }
                else if (Num == 3)
                {
                    Console.WriteLine("Capacity of StateName List is: " + StateName.Capacity);
                    Console.WriteLine();
                }
                else if (Num == 4)
                {
                    Console.WriteLine("Count of StateName List is: " + StateName.Count);
                    Console.WriteLine();
                }
                else if (Num == 5)
                {
                    Console.WriteLine("Capital");
                    Console.WriteLine("=========================");
                    foreach (var key in StateName)
                    {
                        Console.WriteLine("Capital: {0} ",key.Value);
                    }
                    Console.WriteLine();
                }
                else if (Num == 6)
                {
                    Console.WriteLine("State         Capital");
                    Console.WriteLine("================================");
                    foreach (var key in StateName)
                    {
                        Console.WriteLine("State: {0}, Capital: {1}", key.Key, key.Value);
                    }
                    Console.WriteLine();
                }
                else if (Num == 7)
                {
                    StateName.Clear();
                    Console.WriteLine("List Is Clear");
                    Console.WriteLine("Numbers of Elements in the List: " + StateName.Count);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Wrong Choices");
                }
            }

           
            Console.ReadKey();
        }
    }
}
