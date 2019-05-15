using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Assignment Number 11. Author:- Ashish B 
 Display string in forward and reverse order 
 by each character using loop and in-build function* 
 */
namespace Training
{
    class strfwdrev
    {
        public void revfwdstr()
        {
            string source = "Selenium Testing Batch";
            // string result;
           
            char[] chars = source.ToCharArray();
            char[] result = new char[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("{0}", chars[i]);
            }
            Console.Write("\n\n");
            int j = source.Length - 1;
            for (int i = 0; i < chars.Length; i++)
            {
                
                result[i] = chars[j];
                j--;
                Console.Write("{0}", result[i]);
            }
            Console.Write("\n\n");
            char[] charArray = source.ToCharArray();
            Array.Reverse(charArray);
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write("{0}", charArray[i]);
            }

            Console.ReadKey();
            
        }
    }
}
