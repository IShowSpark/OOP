using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        string surname;
        string status;
        int age;
        int salary;
        string name;
        int height;
        public Person() { }
        public Person(string Surname)
        {
            surname = Surname;
        }
        public string Surname
        {
            set { if (surname == null) surname = value; }
            get { return surname; }
        }
        public int Age
        {
            set
            {
                age = value;
                if (age<7)
                {
                    status = "Kids";
                }
                else if (age < 17)
                {
                    status = "Teen";
                }
                else if (age < 24)
                {
                    status = "Student";
                }
                else
                {
                    status = "Adult";
                }
            }
            get { return age; }
        }
        public string Status
        {
            get { return status; }
        }
        public string Name
        {
            set { if (name == null) name = value; }
            get { return name; }
        }
        public int Height
        {
            set
            {
                height = value;
                if (height < 140)
                {
                    status = "Short";
                }
                else if (height < 180)
                {
                    status = "Nprmal";
                }
                else
                {
                    status = "Over height";
                }
            }
            get { return height; }
        }
        public int Salary
        {
            set
            {
                salary = value;
                if (salary < 600)
                {
                    status = "Small salary";
                }
                else if (salary < 1200)
                {
                    status = "Medium salary";
                }
                else
                {
                    status = "BIG SALARY";
                }
            }
            get { return salary; }
        }
        //public void Hello()
        //{
        //    Console.WriteLine("My surname is "+ surname);
        //    Console.WriteLine($"I'm {age} and I'm {status}");
        //}
        public void Bye()
        {
            Console.WriteLine("My name is "+ name);
            Console.WriteLine($"I'm {height} cm and my salary {salary}");
        }

    }
}
