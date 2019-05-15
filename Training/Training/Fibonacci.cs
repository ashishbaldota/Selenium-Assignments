using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment Number 4. Author:- Ashish B 
 * display the first n terms of Fibonacci series
 * Fibonacci series 0 1 2 3 5 8 13 .....
 * Expected Output :
   Here is the Fibonacci series upto to 10 terms : 
   0 1 1 2 3 5 8 13 21 34
 */
namespace Training
{
    class Fibonacci
    {
        public void FibonacciDisplay()
        { 
        int n1 = 0, n2 = 1, n3, i, number;
        Console.Write("Enter the number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i<number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
    Console.ReadLine();
        }
    }
}
