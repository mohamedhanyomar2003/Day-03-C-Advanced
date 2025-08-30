using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class LibraryEngine
    {
        //public static void ProcessBooks(List<Book> bList,CustomFunc fPtr)
        //{
        //    foreach (Book b in bList)
        //    {
        //        Console.WriteLine(fPtr(b));
        //    }
        //}

        public static void ProcessBooks(List<Book> bList, Func<Book,string> fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }

    }
}
