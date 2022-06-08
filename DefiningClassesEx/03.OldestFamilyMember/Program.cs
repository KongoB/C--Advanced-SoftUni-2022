using System;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] newPerson = Console.ReadLine().Split();
                string personName = newPerson[0];
                int personAge = int.Parse(newPerson[1]);

                family.AddMember(new Person(personName, personAge));
            }

            family.GetOldestMember();

        }
    }
}
