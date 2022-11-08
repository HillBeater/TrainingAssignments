using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_new
{
   internal class Student
    {

        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
        public int RollNumber { get; set; }
       

        public void add(int id, string name, int standard, int rollnumber)
        {
            this.Id = id;
            this.Name = name;
            this.Standard = standard;
            this.RollNumber = rollnumber;

            Console.WriteLine("Student Details");
            Console.WriteLine("Student ID " + Id);
            Console.WriteLine("Student Name " + Name);
            Console.WriteLine("Student Standard " + Standard);
            Console.WriteLine("Student RollNumber " + RollNumber);
            Console.WriteLine();
        }

    }
}



    


   

