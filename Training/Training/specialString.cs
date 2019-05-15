using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Assignment Number 10. Author:- Ashish B 
 Remove spaces or any special character like (@,#,$,%,*) 
 from string to empty string using loop and in-build function*
 */
namespace Training
{
    class specialString
    {
        public void specialstring()
        {
            string source = "String Contain @#$%* @ $ also again contain # *";
            string final="";
           
            for (int i = 0; i < source.Length; i++)
            {
                if ((source[i]!='@') & (source[i] != '#') & (source[i] != '$') & (source[i] != '%') & (source[i] != '*') & (source[i] != ' '))
                {
                    final = final + source[i];

                }
            }
            Console.WriteLine(source);
           Console.WriteLine(final);
            Console.ReadKey();
            string source1 = "String Contain @#$%* @ $ also again contain # *";
            string final1 = Regex.Replace(source1, "[@|#|$|%|*| ]", string.Empty);
         
            Console.WriteLine(source1);
            Console.WriteLine(final1);
            Console.ReadKey();
        }
    }
}
