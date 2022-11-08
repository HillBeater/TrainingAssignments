using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val;
            int num;
            var Student = new Dictionary<int, string>
            { 
               //KEY, NAME
                {1, "Anurag" },
                {2, "Robin" },
                {3, "Ankit" }
            };

            //Adding items by Index Notation

                 //KEY     NAME
            Student[4] = "Mukul";
            Student[5] = "Rohit";
            Student[6] = "Deepak";

            //ADD Method

                     //KEY  Name
            Student.Add(7, "Robin Mehra");
            Student.Add(8, "Amit");
            Student.Add(9, "Sagar");

            foreach(var items in Student)
            {
                Console.WriteLine($"key: {items.Key}, Value: {items.Value}");
            }
            Console.WriteLine();

            while(Student.Count > 0)
            {
                Console.WriteLine("Enter 1 for Add New Detail");
                Console.WriteLine("Enter 2 for Remove Detail By Key");
                Console.WriteLine("Enter 3 for Count the Students");
                Console.WriteLine("Enter 4 for Display the Students Key and Name");
                Console.WriteLine("Enter 5 for Display the Students Name");
                Console.WriteLine();
                val = Console.ReadLine();
                num = Convert.ToInt32(val);
                Console.WriteLine();

                if (num == 1)
                {
                    Console.WriteLine("Enter Student Key");
                    string NewItem = Console.ReadLine();
                    int Key = Convert.ToInt32(NewItem);
                    Console.WriteLine("Enter Student Name");
                    string Name = Console.ReadLine();
                   
                    if (Student.ContainsKey(Key))
                    {
                        Console.WriteLine("Key Already Exist");
                    }
                    else
                    {
                        Student.Add(Key, Name);
                        Console.WriteLine("New Student Added");
                    }
                    Console.WriteLine();
                }
                else if (num == 2)
                {
                    Console.WriteLine("Enter Key To Delete student");
                    string NewItem = Console.ReadLine();
                    int Key = Convert.ToInt32(NewItem);
                    if (Student.ContainsKey(Key))
                    {
                        Student.Remove(Key);
                        Console.WriteLine("Student Details Delete");
                    }
                    else
                    {
                        Console.WriteLine("Key not Find");
                    }
                   
                    Console.WriteLine();
                }
                else if (num == 3)
                {
                    Console.WriteLine("Total Numbers of Students");
                    Console.WriteLine(Student.Count);
                    Console.WriteLine();
                }
                else if (num == 4)
                {
                    Console.WriteLine("Student Details With Key");
                    foreach (var items in Student)
                    {
                        Console.WriteLine($"key: {items.Key}, Value: {items.Value}");
                    }
                    Console.WriteLine();
                }
                else if (num == 5)
                {

                    Console.WriteLine("All Students Name");
                    foreach (var item in Student)
                    {
                        Console.WriteLine("Student Name " + item.Value);
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
