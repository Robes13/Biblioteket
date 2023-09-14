using Biblioteket.Model;
using Biblioteket.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket.Controller
{
    /// <summary>
    /// This class is responsible for handling book loans
    /// </summary>
    internal class LoanBook
    {
        Stack<Book> loanedBooks = new Stack<Book>();
        Gui gui = new Gui();

        public void WantToLoanBook(List<Book> availAbleBooks, List<Book> libary)
        {
            // Displaying the available books to loan.
            gui.DisplayBooks(availAbleBooks);
            gui.BookToLoanText();
            // WantedBook is the book that the user wants to loan.
            string wantedBook = Console.ReadLine();
            // This byte represents if the book was loaned or not. If it was loaned, it will be more than 0. Else it will stay 0.
            byte foundBook = 0;
            if (wantedBook == "return" || wantedBook == "Return")
            {
                gui.BookYouWantToReturn();
                string returnBook = Console.ReadLine();
                Book nextBook = loanedBooks.Peek();
                if (returnBook == nextBook.Title)
                {
                    // Removing book from stack.
                    loanedBooks.Pop();
                    foundBook++;
                    // Telling the user that the book was returned
                    gui.BookReturned(nextBook.Title);
                    // Adding the book back to the available books.
                    availAbleBooks.Add(nextBook);
                }
            }
            if (foundBook == 0)
            {
                foreach (Book book in availAbleBooks)
                {
                    if (wantedBook == book.Title)
                    {
                        // Adding the loaned book to the stack.
                        loanedBooks.Push(book);
                        availAbleBooks.Remove(book);
                        foundBook++;
                        gui.LoanSuccesful(book.Title);
                        break;
                    }
                }
            }
            if (foundBook == 0)
            {
                gui.LoanFailed(wantedBook);
            }
        }
    }
}
