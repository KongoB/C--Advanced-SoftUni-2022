using System;
using System.IO;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {


            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {

                int rowCounter = 0;

                while (!reader.EndOfStream)
                {

                    if (rowCounter % 2 == 0)
                    {
                        string[] words = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


                        for (int j = 0; j < words.Length / 2; j++)
                        {
                            string temp = words[j];
                            words[j] = words[words.Length - 1 - j];
                            words[words.Length - 1 - j] = temp;
                        }

                        string replaceSymbols = String.Join(" ", words);


                        for (int j = 0; j < replaceSymbols.Length; j++)
                        {

                            switch (replaceSymbols[j])
                            {
                                case '-':
                                    replaceSymbols = replaceSymbols.Replace('-', '@');
                                    break;
                                case ',':
                                    replaceSymbols = replaceSymbols.Replace(',', '@');
                                    break;
                                case '.':
                                    replaceSymbols = replaceSymbols.Replace('.', '@');
                                    break;
                                case '!':
                                    replaceSymbols = replaceSymbols.Replace('!', '@');
                                    break;
                                case '?':
                                    replaceSymbols = replaceSymbols.Replace('?', '@');
                                    break;
                            }

                        }

                        Console.WriteLine(replaceSymbols);

                    }
                    else
                    {
                        reader.ReadLine();
                    }

                    rowCounter++;

                }

            }

            
        }
    }
}
