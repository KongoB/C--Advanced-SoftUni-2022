using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> wordsToMatch = new List<string>();

            Dictionary<string, int> matches = new Dictionary<string, int>();



            using (StreamReader reader = new StreamReader("../../../words.txt"))
            {

                while (!reader.EndOfStream)
                {
                    wordsToMatch.Add(reader.ReadLine().ToLower());
                }
            }

            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {

                while (!reader.EndOfStream)
                {

                    string[] row = reader.ReadLine().ToLower().Split(new string[] { "-", ",", ".", "!", "?", " " }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < wordsToMatch.Count; i++)
                    {
                        
                        for (int j = 0; j < row.Length; j++)
                        {

                            if (wordsToMatch[i] == row[j])
                            {

                                if (!matches.ContainsKey(row[j]))
                                {
                                    matches.Add(row[j], 0);
                                }

                                matches[row[j]]++;
                            }
                        }
                    }
                }
            }


            matches = matches.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, x => x.Value);


            using (FileStream fs = new FileStream("../../../actualResult.txt", FileMode.Create, FileAccess.ReadWrite))
            {

                byte[] buffer = new byte[1];


                foreach (var match in matches)
                {

                    buffer = Encoding.UTF8.GetBytes(match.Key + " - " + match.Value + Environment.NewLine);
                    fs.Write(buffer, 0, buffer.Length);

                }
            }
        }
    }
}
