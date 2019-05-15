using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Assignment Number 1. Author:- Ashish B 
 * Write a program in C# Sharp to read 10 numbers from keyboard and find their sum
 * Test Data :
 * Input the 10 numbers : 
 * Number-1 :2 
 * ... 
 * Number-10 :2 
 * Expected Output : 
 * The sum of 10 no is : 51 
 */
namespace Training
{
    class NumberSum
    {

        string input;
        int value;
        int sum = 0;
        public void Calculate()
        { 
        Console.WriteLine("Input the 10 numbers:");
            for (int i = 1; i<=10;i++)
            {
                Console.Write("Number-"+i +":");
                input = Console.ReadLine();
                value = Convert.ToInt32(input);
                sum = sum + value;
            }
            Console.WriteLine("The sum of 10 numbers is :" + sum);
            Console.ReadLine();
        }
    
    }
}
