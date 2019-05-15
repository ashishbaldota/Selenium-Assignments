using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Assignment Number 3. Author:- Ashish B 
Display the pattern like right angle triangle using an asterisk => take number of rows as input 
      *
      **
      ***
      ****
 */
namespace Training
{
    class RightPattren
    {
        public  void RightDesignPattren()
        {
            int i, j, rows;

            Console.Write("Enter number of rows => ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                    Console.Write("\n");
            }
            Console.ReadLine();
        }

    }
}
