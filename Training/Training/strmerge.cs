using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Assignment Number 12. Author:- Ashish B 
 * Merge two string => e.g if first string is "where " and second string is "are you", 
 * then merge these two string by append char or prepend char or insert char according to its position
 * e.g Step 1 =====> 1st string = 'where ', 2nd string = 'are you', ouptput should be in 3rd string
     * 1) Append 2nd to 1st or vice versa = "where are you"
     * 2) Prepend 2nd to 1st or vice versa = ""are youwhere "
     * 3) string1 = "are" string2 = "where"; => arewh, wherea, whare  Insert 2nd string char to 1st string char by indexing or vice versa = "awheyoure" or "whare you"
 * Step 2 ====> Do not use 3rd variable, instead modify current string and follow same steps
 */
namespace Training
{
    class strmerge
    {
        public void merges()
        {
            string str1 = "where ";
            string str2 = "are you";
            string str3 = str1 + str2;
            Console.WriteLine(str3);
            str3 = str2 + str1;
            Console.WriteLine(str3);
            Console.ReadKey();
           string string1 = "are";
            string string2 = "where";
            string Result1,Result2,Result3,Result4, Result5 = "";
            Result1 = string1.Insert(3, string2.Remove(2));
            Console.WriteLine("FINAL RESULT: " + Result1);
            Result2 = string2.Insert(5, string1.Remove(1));
            Console.WriteLine("FINAL RESULT: " + Result2);
            Result3 = string2.Insert(2, string1+string2.PadRight(5));
            Result3 = string2.Remove(2)+string1;
            Console.WriteLine("FINAL RESULT: " + Result3);
            Result4 = str2.Remove(1) + str1.Remove(3)+str2.Substring(3)+str1.Substring(3);
            Console.WriteLine("FINAL RESULT: " + Result4);
            Result5 = str1.Remove(2) + str2;
            Console.WriteLine("FINAL RESULT: " + Result5);


            // ""whare you""

            Console.ReadKey();

        }
    }
}
