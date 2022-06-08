using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            Action<int[]> reverseArray = Array.Reverse;

            reverseArray(array);

            array = array.Where(x => x % n != 0).ToArray();

            Console.WriteLine(String.Join(' ', array));

        }
    }
}
