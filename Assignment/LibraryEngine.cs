using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    // User Defined Delegate
    public delegate string BookFunctionDelegate(Book B);  

    public class LibraryEngine
    {
        // a) Method using user-defined delegate  
        public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // b) Method using built-in delegate  
        public static void ProcessBooksWithFunc(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        // c) Example usage of anonymous method to get ISBN  
        public static void ProcessBooksWithAnonymous(List<Book> bList)
        {
            ProcessBooks(bList, delegate (Book B) {
                return B.ISBN;
            });
        }

        // d) Example usage of lambda expression to get PublicationDate  
        public static void ProcessBooksWithLambda(List<Book> bList)
        {
            ProcessBooksWithFunc(bList, B => B.PublicationDate.ToShortDateString());
        }
    }
}
