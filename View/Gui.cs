using Biblioteket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteket.View
{
    /// <summary>
    /// This class is responsible for handling everything GUI related.
    /// </summary>
    internal class Gui
    {
        // This byte is for keeping tracks of how many books there currently is in the system.
        private byte _count = 0;
        public void DisplayBooks(List<Book> books)
        {
            Console.Clear();
            byte count = 1;
            foreach (var book in books)
            {
                Console.WriteLine($"{count}. {book.Title}");
                count++;
            }
            _count = count;
        }
        public void BookToLoanText()
        {
            Console.SetCursorPosition(0, _count);
            Console.WriteLine("Please enter the name of the book you");
            Console.WriteLine("want to loan, or write return to give back a book: ");
            Console.SetCursorPosition(0, _count + 2);
        }
        public void NoMoreBooks()
        {
            Console.Clear();
            Console.WriteLine("There is no more books available, please come back another time.");
            Console.WriteLine("Press enter to close program");
        }
        public void BookYouWantToReturn()
        {
            Console.WriteLine("Please enter the name of the book you want to return");
        }
        public void LoanSuccesful(string title)
        {
            Console.WriteLine($"You have now loaned {title}.");
            Thread.Sleep(2000);
        }
        public void LoanFailed(string title) 
        {
            Console.WriteLine($"Sorry, {title}, was not found in the system, or its not the most recently loaned book. ");
            Console.WriteLine("You have to return your books in the correct order. Please try again");
            Thread.Sleep(4000);
        }
        public void BookReturned(string title)
        {
            Console.WriteLine($"You have now returned {title}.");
            Thread.Sleep(2000);
        }
    }
}
