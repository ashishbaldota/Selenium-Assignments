using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment Number 9. Author:- Ashish B 
 * Split, Trim and Join string => use LTRIM, RTRIM, TRIM, SPLIT, JOIN methods
 * e.g if string is = " 123| 456| 789" or "123 |456 |789 " or " 123 | 456 | 789 " or "123 | 456|789" then o/p is "123|456|789"
 */
namespace Training
{
    class Trimoperation
    {
        public void trimo()
        {
            // String with whitespaces  
            string input1 = "123 | 456|789";
            Console.WriteLine("Input 1 is:{0}", input1);
            trimss(input1);
            string input2 = "123 |456 |789 ";
            Console.WriteLine("Input 2 is:{0}", input2);
            trimss(input2);
            string input3 = " 123 | 456 | 789 ";
            Console.WriteLine("Input 3 is:{0}", input3);
            trimss(input3);
            string input4 = "123 | 456|789";
            Console.WriteLine("Input 4 is:{0}", input4);
            trimss(input4);
            Console.ReadKey();
        
        }

        public void trimss(String data)
        {
        string[] split = data.Split(new char[] { '|' });

            for (int i = 0; i<split.Length; i++)
            {
                split[i] = split[i].Trim();
            }
            string final;
            // final = String.Join("|",split[0],split[1],split[2]);
            final = String.Join("|",split);
            Console.WriteLine("Result Is:{0}", final);
            Console.Write("\n");

        }

    }
}
