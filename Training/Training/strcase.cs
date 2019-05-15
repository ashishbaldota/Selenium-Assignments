using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment Number 13,14 and 15. Author:- Ashish B 
 13.	Convert the string to Title Case and Camel case.
14. 	Count the no of words in a string.
15. 	Count the distinct words in a string. 
*/
namespace Training
{
    class strcase
    {
        //Convert the string to Title Case and Camel case.
        public void cnvclasses()
        {
            //PayPal, iPhone, MasterCard.
            string str = "title case";
            string str1 = "Iphone";
            string result1;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            str = textInfo.ToTitleCase(str);
            // str1 = textInfo.ToLower(str1);
            Console.WriteLine(str);
            // Console.WriteLine(str1);

            // If there are 0 or 1 characters, just return the string.
            if (str1 == null || str1.Length < 2)
                result1 = str1;

            // Split the string into words.
            string[] words = str1.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }
            Console.WriteLine(result);
            Console.ReadKey();
            countwords();
            distinctword();
        }

        //Count the no of words in a string.
        public void countwords()
        {
            string str = "We are learning selenium using c#";
            Console.WriteLine(str);
            int count = 1, i;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        //Count the distinct words in a string.
        public void distinctword()
        {
            string str = "c# We are learning are selenium using c# selenium";
            var words = str.Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = words.Distinct();
            Console.WriteLine("Distinct count{0}",result.Count());
            Console.ReadKey();
        }
    }
}
