using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Assignment Number 5. Author:- Ashish B 
 Convert 2D array into 1D array
	- create 2D array by taking input from user for its size
	- fill it by taking input from user
	- print it
	- convert it into 1D array
*/
namespace Training
{
    class _2DArray
    {
        public void arrayd()
        {
            int[,] number;
            int dim1, dim2,onedim;
            // create 2D array by taking input from user for its size
            Console.Write("Enter number of rows for 2D Array Size:");
            dim1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns for 2D Array Size:");
            dim2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2D Array Size is:{0} {1}", dim1, dim1);
            onedim = 0;
            number = new int[dim1, dim2];
            int[] num;
            num = new int[dim1*dim2];
            //fill it by taking input from user
            for (int i = 0; i < dim1; i++)
            {

                for (int j = 0; j < dim2; j++)
                {
                    Console.WriteLine("Enter Array element Of Position:{0}{1}", i, j);
                    int element;
                    element = Convert.ToInt32(Console.ReadLine());
                    number[i,j] = element;
                }
            }
            //print 2 D Array
            Console.WriteLine("2D Array values are:-");
            for (int i = 0; i < dim1; i++)
            {

                for (int j = 0; j < dim1; j++)
                {
                    Console.WriteLine("Array element Of Position:{0}{1} is: {2}", i, j, number[i,j]);
                  
                }
            }
            // Convert 2D Array To 1D
            Console.WriteLine("2D Array converted to 1D Array values are:-");
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    num[onedim++] = number[i, j];
                }
            }
            // Print 1D Array
            for (int i1 = 0; i1 < num.Length; i1++)
            {

                Console.WriteLine("Array element Of Position {0} is: {1}",i1,num[i1]);

            }
            Console.ReadKey();

        }
    }
}
