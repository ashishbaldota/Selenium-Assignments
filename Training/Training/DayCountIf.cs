using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Assignment Number 2. Author:- Ashish B 
 * Traverse for loop from 1 to 7 and display each day name using if and switch
 */
namespace Training
{
    class DayCountIf
    {
        public void Daycount()
        {
            string day;
            Console.WriteLine("Days using IF:-");
            for (int i = 1; i <= 7; i++)
            {
                if (i == 1)
                {
                    day = "Monday";
                    Console.WriteLine("1st day of the week=>" + day);
                }
                if (i == 2)
                {
                    day = "Tuesday";
                    Console.WriteLine("2nd day of the week=>" + day);
                }
                if (i == 3)
                {
                    day = "Wednesday";
                    Console.WriteLine("3rd day of the week=>" + day);
                }
                if (i == 4)
                {
                    day = "Thursday";
                    Console.WriteLine("4th day of the week=>" + day);
                }
                if (i == 5)
                {
                    day = "Friday";
                    Console.WriteLine("5th day of the week=>" + day);
                }
                if (i == 6)
                {
                    day = "Saturday";
                    Console.WriteLine("6th day of the week=>" + day);
                }
                if (i == 7)
                {
                    day = "Sunday";
                    Console.WriteLine("7th day of the week=>" + day);
                }


            }
            Console.ReadLine();

        }
        
    }
}
