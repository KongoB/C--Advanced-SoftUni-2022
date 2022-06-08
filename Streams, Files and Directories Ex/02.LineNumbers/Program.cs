using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                int lineCounter = 1;
                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();
                    int letterCounter = 0;
                    int punctuationCounter = 0;

                    for (int i = 0; i < currentLine.Length; i++)
                    {

                        char current = currentLine[i];

                        if (char.IsLetterOrDigit(current))
                        {

                            letterCounter++;

                        }
                        else if (!char.IsWhiteSpace(current))
                        {
                            punctuationCounter++;
                        }

                    }


                    Console.WriteLine($"Line {lineCounter}: {currentLine} ({letterCounter})({punctuationCounter})");
                    lineCounter++;
                }

            }


        }
    }
}
