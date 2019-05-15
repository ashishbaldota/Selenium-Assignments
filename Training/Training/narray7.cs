using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Assignment Number 7. Author:- Ashish B 
 Read 'n' number of values in an array and display it in reverse 
Assignment Number 8. Author:- Ashish B 
Find maximum and minimum element in an array
 */
namespace Training
{
    class narray7
    {
        public void readnarray()
        {

            int number;
            int[] ary;
            Console.Write("Enter Number Of Elements to be added in Array:");
            number = Convert.ToInt32(Console.ReadLine());
            ary = new int[number];
            for (int i = 0; i <number; i++)
            {
                Console.WriteLine("Enter Value of position {0}:", i);
                ary[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write("{0} ", ary[i]);
             
            }
            Console.Write("\n");
            Console.WriteLine("Resverse Of Array Is:-");
            for (int i = number - 1; i >= 0; i--)
            {
                Console.Write("{0} ", ary[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
            int min, max;
            max = ary[0];
            min = ary[0];

            for (int i = 1; i < number; i++)
            {
                if (ary[i] > max)
                {
                    max = ary[i];
                }


                if (ary[i] < min)
                {
                    min = ary[i];
                }
            }
            Console.WriteLine("Maximum element is : {0}", max);
            Console.WriteLine("Minimum element is : {0}", min);
            Console.ReadKey();
        }
    }
}
