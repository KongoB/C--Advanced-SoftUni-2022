using System;
using System.Linq;

namespace Testing
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());




        }

        static Func<Person, bool> GetAgeCondition(string filter, int filterAge)
        {

            switch (filter)
            {
                case "young": return p => p.Age < filterAge;
                case "older": return p => p.Age > filterAge;
                default:
                    return null;
            }

        }


        static void People(Person[] people, 
            Func<Person, bool> condition)
        {
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(person.Name);
                }



            }
        }

    }
}
