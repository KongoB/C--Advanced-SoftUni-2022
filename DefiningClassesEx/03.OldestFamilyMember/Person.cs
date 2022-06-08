using System;
using System.Collections.Generic;
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

    }

}
