namespace Assignment
{
    public delegate string CustomFunc(Book b);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.A
            ////User Defined Delegate Datatype
            //List<Book> books = new List<Book>();
            //Book book1 = new Book("123", "shams", ["Ahmed", "Mohamed"], new DateTime(22, 12, 3), 40000m);
            //Book book2 = new Book("123", "Moon", ["Mohamed", "Ali"], new DateTime(22, 12, 3), 77m);
            //books.Add(book1);
            //books.Add(book2);
            //LibraryEngine.ProcessBooks(books,BookFunctions.GetPrice);
            //LibraryEngine.ProcessBooks(books,BookFunctions.GetAuthors);
            #endregion

            #region Q1.B
            //// BCL Delegates
            //List<Book> books = new List<Book>();
            //Book book1 = new Book("123", "shams", ["Ahmed", "Mohamed"], new DateTime(22, 12, 3), 40000m);
            //Book book2 = new Book("123", "Moon", ["Mohamed", "Ali"], new DateTime(22, 12, 3), 77m);
            //Book book3 = new Book("123", "Earth", ["Mohamed", "Hany"], new DateTime(22, 12, 3), 877m);
            //books.Add(book1);
            //books.Add(book2);
            //books.Add(book3);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            //LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            #endregion

            #region Q1.C
            ////nonymous Method (GetISBN)
            //List<Book> books = new List<Book>();
            //Book book1 = new Book("123", "shams", ["Ahmed", "Mohamed"], new DateTime(22, 12, 3), 40000m);
            //Book book2 = new Book("123", "Moon", ["Mohamed", "Ali"], new DateTime(22, 12, 3), 77m);
            //Book book3 = new Book("123", "Earth", ["Mohamed", "Hany"], new DateTime(22, 12, 3), 877m);
            //books.Add(book1);
            //books.Add(book2);
            //books.Add(book3);
            //LibraryEngine.ProcessBooks(books, delegate (Book b) { return $"Title : {b.Title}"; });
            //LibraryEngine.ProcessBooks(books, delegate (Book b) {return $"Authors : {string.Join(", ", b.Authors)}";});
            //LibraryEngine.ProcessBooks(books, delegate (Book b) { return $"Price : {b.Price:c}";});
            ////LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            ////LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            #endregion

            #region Q1.D
            ////Lambda Expression(GetPublicationDate)
            //List<Book> books = new List<Book>();
            //Book book1 = new Book("123", "shams", ["Ahmed", "Mohamed"], new DateTime(22, 12, 3), 40000m);
            //Book book2 = new Book("123", "Moon", ["Mohamed", "Ali"], new DateTime(22, 12, 3), 77m);
            //Book book3 = new Book("123", "Earth", ["Mohamed", "Hany"], new DateTime(22, 12, 3), 877m);
            //books.Add(book1);
            //books.Add(book2);
            //books.Add(book3);
            //LibraryEngine.ProcessBooks(books, b => $"Title : {b.Title}");
            //LibraryEngine.ProcessBooks(books, b => $"Authors : {string.Join(", ", b.Authors)}" );
            //LibraryEngine.ProcessBooks(books, b => $"Price : {b.Price:c}");

            #endregion

        }
    }
}
