using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
     public class DateMofidier
    {

        public DateMofidier(DateTime firstDate, DateTime secondDate)
        {

            FirstDate = firstDate;
            SecondDate = secondDate;

        }


        public DateTime FirstDate { get; set; }

        public DateTime SecondDate { get; set; }


        public void DifferenceInDays()
        {

            var differenceInDays = FirstDate - SecondDate;

            Console.WriteLine(Math.Abs(differenceInDays.Days));

        }


    }

}
