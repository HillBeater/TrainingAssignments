using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_new
{
    internal class Program : Student
    {
        static void Main(string[] args)
        {
            Hashtable myhash = new Hashtable();
            Student student = new Student();

            while (true)
            {
                Console.WriteLine("Press 1 for insertion");
                Console.WriteLine("Press 2 for deletion");
                Console.WriteLine("Press 3 for searching");
                Console.WriteLine("Press 4 for retrieving");
                Console.WriteLine();
                int choice;
                Console.Write("Enter your Choice: ");
                
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the Details of student");
                            Console.WriteLine("Enter the student ID");
                            student.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the student Name");
                            student.Name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the student Standard");
                            student.Standard = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the student RollNumber");
                            student.RollNumber = Convert.ToInt32(Console.ReadLine());
                            student.add(student.Id, student.Name, student.Standard, student.RollNumber);
                            myhash.Add(student.RollNumber, student);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the Roll Number of student whose record has to be deleted");
                            var StdRollNumber = Convert.ToInt32(Console.ReadLine());
                            myhash.Remove(StdRollNumber);
                            Console.WriteLine("All the Details of Roll Number " + StdRollNumber + " has been deleted");
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Roll Number whose record has been search");
                            var searchStd = Convert.ToInt32(Console.ReadLine());
                            foreach (Student std in myhash.Values)
                            {
                                if (myhash.ContainsKey(searchStd))
                                {
                                    Console.WriteLine("Student Details Avilable");
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Student Details Unavilable");
                                    Console.WriteLine();
                                    break;
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (Student std in myhash.Values)
                            {
                                Console.WriteLine("Student Details");
                                Console.WriteLine("Student ID " + std.Id);
                                Console.WriteLine("Student Name " + std.Name);
                                Console.WriteLine("Student Standard " + std.Standard);
                                Console.WriteLine("Student RollNumber " + std.RollNumber);
                                Console.WriteLine();
                            }
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }


            }
        }
    }
}
    

