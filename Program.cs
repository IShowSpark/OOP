using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person();
            man.Surname = "Zelenskij";
            man.Age = 44;
            man.Height = 180;
            man.Salary = 1600;
            Console.WriteLine($"{man.Surname} is {man.Age},{man.Height},{man.Salary}");
            //man.Hello();
            man.Bye();
            Person[] people = new Person[1];
            for (int i = 0; i < 1; i++)
            {
                people[i] = new Person();
                Console.WriteLine("What's your surname?");
                people[i].Surname = Console.ReadLine();
                Console.WriteLine("How old are you?");
                try
                {
                    people[i].Age = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }
                Console.WriteLine("What's your name?");
                people[i].Name = Console.ReadLine();
                Console.WriteLine("What's your height?");
                try
                {
                    people[i].Height = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }
                Console.WriteLine("What's your salary?");
                try
                {
                    people[i].Salary = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                }
            }
            foreach (Person person in people)
            {
                //person.Hello();
                person.Bye();
            }
            Console.ReadKey();
        }

    }
}
