using System;
using System.IO;
using System.Linq;

namespace _01.EventLinesFollow
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {

                string line = reader.ReadLine();
                int counter = 0;

                while (line != null)
                {

                    if (counter++ % 2 == 0)
                    {

                        string[] words = line.Split(new string[] { "-", ",", ".", "!", "?", " "}, StringSplitOptions.RemoveEmptyEntries);


                        Console.WriteLine(string.Join("@", words.Reverse()));

                    }


                    line = reader.ReadLine();

                }



            }
        }
    }
}
