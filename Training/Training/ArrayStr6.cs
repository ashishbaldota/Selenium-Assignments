using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Assignment Number 6. Author:- Ashish B 
 * Find and locate item in string array
	- create and fill string array
	- check input value is exists in array. print true or false with find position
*/
namespace Training
{
    class ArrayStr6
    {
        public void arraydstr()
        {
            String[] books;
            String Names;
            books = new string[5];
            for (int i=0;i<=4;i++)
            {
                Console.WriteLine("Enter Book Name of position {0}:",i);
                books[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter Book Name To Search In Array:");
            Names= Console.ReadLine();
            if (books.Contains(Names))
            {
                int pos = Array.IndexOf(books, Names);
                Console.WriteLine("Book Found at Location: {0}", pos);
                
            }
            else
                Console.WriteLine("Book Not Found");
            //try
            //{
            //    for (int i = 0; i <= 4; i++)
            //    {
            //        if (books[i] == Names)
            //        {
            //            Console.WriteLine("Book Found at Location {0}", i);
            //        }
            //        Console.WriteLine("Book Not Found");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Book Not Found");
            //}
         
              Console.ReadKey();
        }
   
    }
}
