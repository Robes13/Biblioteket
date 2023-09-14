using Biblioteket.Model;
using Biblioteket.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket.Controller
{
    /// <summary>
    /// This class runs the entire program.
    /// </summary>
    internal class Controller
    {
        public void Start()
        {
            // These books are all the books in the libary.
            Book littleMermaid = new Book(212, "The Little Mermaid");
            Book theLionKing = new Book(257, "The Lion King");
            Book bambi = new Book(179, "Bambi");
            Book donaldDuck = new Book(124, "Donald Duck");
            // This list is the available books.
            List<Book> availableBooks = new List<Book>()
            {
                littleMermaid, theLionKing, bambi, donaldDuck
            };
            // This is all the books registered in the libary.
            List<Book> libary = new List<Book>()
            {
                littleMermaid, theLionKing, bambi, donaldDuck
            };
            Gui gui = new Gui();
            // Displaying the current books in the libary.
            gui.DisplayBooks(availableBooks);
            gui.BookToLoanText();
            LoanBook loanBook = new LoanBook();
            // This while loop runs the entire program, you can keep loaning and returning books, are loan all the books.
            while (availableBooks.Count > 0)
            {
                loanBook.WantToLoanBook(availableBooks, libary);
            }
            gui.NoMoreBooks();
            Console.ReadLine();
        }
    }
}
