using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) : this ()
        {
            Age = age;
        }

        public Person(string name, int age) : this (age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class Family
    {

        List<Person> family = new List<Person>();

        public void AddMember(Person member)
        {
            family.Add(member);
        }

        public void GetOldestMember()
        {
            int indexTracker = 0;
            int highestIndex = 0;

            foreach (var person in family)
            {
                if (highestIndex < person.Age)
                {
                    highestIndex = indexTracker;
                }
                indexTracker++;
            }

            Console.WriteLine(family[highestIndex].Name + " " + family[highestIndex].Age);

        }

        public void AgeAbove30()
        {
            List<Person> elderly = new List<Person>();

            elderly = family.Where(p => p.Age > 30).ToList();

            elderly = elderly.OrderBy(x => x.Name).ToList();


            foreach (var person in elderly)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

    }

}
