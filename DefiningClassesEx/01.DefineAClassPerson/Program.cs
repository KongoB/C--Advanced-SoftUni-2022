using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Person pesho = new Person();
            Person gosho = new Person();
            Person stamat = new Person();

            pesho.Name = "Pesho";
            pesho.Age = 20;
            gosho.Name = "Gosho";
            gosho.Age = 18;
            stamat.Name = "Stamat";
            stamat.Age = 43;


        }
    }
}
