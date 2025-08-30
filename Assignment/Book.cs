using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        private decimal price;
        public Book(string iSPN, string title, string[] authors, DateTime publicatiobDate, decimal price)
        {
            ISPN = iSPN;
            Title = title;
            Authors = authors;
            PublicationbDate = publicatiobDate;
            Price = price>0?price:0;
        }

        public string ISPN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationbDate { get; set; }
        public decimal Price { get=> price; set =>price = value > 0 ? value : 0; }

        public override string ToString()
        {
            return $"Ispn: {ISPN}, Title: {Title}, Authors: {string.Join(", ",Authors)} ,Publication Date: {PublicationbDate}, Price:{Price:c}";
        }
    }
}
