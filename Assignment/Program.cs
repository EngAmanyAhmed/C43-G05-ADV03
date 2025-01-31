namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            /* 1. Write Down the Body of all Listed Methods and Properties and Constructor
               2. You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 
                  a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
                  b) Use the Proper build in delegate. 
                  c) Anonymous Method (GetISBN).
                  d) Lambda Expression (GetPublicationDate).
             */

            List<Book> books = new List<Book>
            {
                new Book("978-3-16-148410-0", "C# Programming", new[] { "Author One", "Author Two" }, new DateTime(2020, 1, 1), 29.99m),
                new Book("978-1-56619-909-4", "Advanced C#", new[] { "Author Three" }, new DateTime(2021, 5, 15), 39.99m),
                new Book("978-0-201-63361-0", "Learning C#", new[] { "Author Four", "Author Five" }, new DateTime(2022, 3, 10), 19.99m)
            };

            // a) Using user-defined delegate to get titles  
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            // b) Using built-in delegate to get authors  
            LibraryEngine.ProcessBooksWithFunc(books, BookFunctions.GetAuthors);

            // c) Using anonymous method to get ISBNs  
            LibraryEngine.ProcessBooksWithAnonymous(books);

            // d) Using lambda expression to get publication dates  
            LibraryEngine.ProcessBooksWithLambda(books);

            #endregion
        }
    }
}
