using System;
using System.Globalization;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime firstDate = DateTime.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("de-DE"));
            DateTime secondDate = DateTime.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("de-DE"));

            DateMofidier asd = new DateMofidier(firstDate, secondDate);

            asd.DifferenceInDays();

        }
    }
}
