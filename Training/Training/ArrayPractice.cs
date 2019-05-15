using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class ArrayPractice
    {
        public void secondarrayt()
        {
            int[] n = new int[10]; /* n is an array of 10 integers */
            int i, j;

            /* initialize elements of array n */
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                //Console.WriteLine("Element[{0}] = {1}", j, n[j]);
                Console.WriteLine("{0}{1}{2}{3}",j,n[j],j,n[j]);
            }
            Console.ReadKey();
            
            int[,] names;
            //names = new int[2, 2] { { 1, 2 }, {3,4} };
            names = new int[2, 2];
            Console.WriteLine("Loop Started");
            for (int i1=0;i1<=1;i1++)
            {
            
                for (int j1=0;j1<=1;j1++)
                {
                    Console.WriteLine("Enter Array element:{0}{1}",i1,j1);
                    int element;
                    element = Convert.ToInt32(Console.ReadLine());
                    names[i1,j1] = element;
                }
            }
            
            // names[0,0] =500;
            Console.WriteLine(names[0,0]);
            Console.WriteLine(names[0,1]);
            Console.WriteLine(names[1,0]);
            Console.WriteLine(names[1,1]);
            Console.ReadKey();

            //int[] a;  //Declare Arrary
            //a = new int[10]; // Initialize Array
            //a[0] = 100;
            //Console.WriteLine(a[9]);
            //Console.ReadKey();

            //int[] a1 = new int[] { 1, 2 };
            //Console.WriteLine(a1[1]);
            //Console.ReadKey();

            //int[,] a = new int[5, 3] { { 0, 0,1 }, { 1, 2,2 }, { 2, 4,3 }, { 3, 6,4 }, { 4, 8,5 } };
            //int i, j;

            ///* output each array element's value */
            //for (i = 0; i < 5; i++)
            //{

            //    for (j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
            //    }
            //}
            //Console.ReadKey();
        }

       
    }
}
