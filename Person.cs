using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        string surname; // поле фамилия
        string status; // поле статус
        int age; // поле возраст
        int salary; // поле зарплата
        string name; // поле имя
        int height; // поле рост
        Language emakeel;
        public Person() { } // пустой конструктор
        public Person(string Surname,Language emakeel)
        {
            surname = Surname;
            this.emakeel = emakeel;
        }
        public string Surname //свойство для поля фамилия
        {
            set { if (surname == null) surname = value; } // код - установка значения поля фамилия
            get { return surname; } // код - чтение значения поля фамилия
        }
        public int Age // свойство для поля возраста
        {
            get { return age; } // код - чтение значения поля возраста
            set { } // код - пустой для установки значения поля возраста
        }
        public string Status // свойство для поля статуса
        {
            get // код - чтение значения поля статус
            {
                if (age < 7)
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
                return status;
            }
        }
        public string Name // свойство для поля имени
        {
            set { if (name == null) name = value; } // код - установка значения поля имя
            get { return name; } // код - чтение значения поля имя
        }
        public int Height // свойство для поля роста
        {
            set // код - установка значения полей роста
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
            get { return height; } // код - чтение значения поля роста
        }
        public int Salary // свойство для поля зарплаты
        {
            set // // код - установка значения полей зарплаты
            {
                salary = value;
                if (salary < 600)
                {
                    status = "small salary";
                }
                else if (salary < 1200)
                {
                    status = "medium salary";
                }
                else
                {
                    status = "BIG SALARY";
                }
            }
            get { return salary; } // // код - чтение значения поля зарплата
        }
        public Language Emakeel
        {
            get { return emakeel; } // код - чтение значения поля emakeel
        }
        //public void Hello()
        //{
        //    Console.WriteLine("My surname is "+ surname);
        //    Console.WriteLine($"I'm {age} and I'm {status}");
        //}
        public void Bye()
        {
            if(surname!=null && name != null)
            {
                Console.WriteLine($"Hello! My name is {name},{surname}");
            }
            else if (surname == null && name != null)
            {
                Console.WriteLine($"Hello! My surname is {surname}");
            }
            else if (name == null && name != null)
            {
                Console.WriteLine($"Hello! My name is {name}");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I'm {height} cm and my salary {salary} and this {Status}");
        }
    }
}
