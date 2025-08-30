using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BookFunctions
    {
        public static string GetTitle(Book b)
        {
            if (b is not null)
                return $"Title : {b.Title}";
            else return "Not Found Book";
        }

        public static string GetAuthors(Book b)
        {
            if (b?.Authors?.Length>0)
                return $"Authors : {string.Join(", ",b.Authors)}";
            else return "Not Found Book";
        }

        public static string GetPrice(Book b)
        {
            if (b is not null)
                return $"Price : {b.Price:c}";
            else return "Not Found Book";
        }
    }
}
