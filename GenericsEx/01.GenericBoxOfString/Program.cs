using System;
using System.Collections.Generic;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                //Box<string> test = new Box<string>(Console.ReadLine());
                Box<int> test = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(test);
            }

        }
    }
}
