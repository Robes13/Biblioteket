using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket.Model
{
    /// <summary>
    /// This class is for specifying what makes up a Book Object.
    /// </summary>
    internal class Book
    {
        private ushort _pages;
        private string _title;
        /// <summary>
        /// Here we are saying that every time we want a book object, we have to enter a page amount and title.
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="title"></param>
        public Book(ushort pages, string title) 
        {
            _pages = pages;
            _title = title;
        }

        public ushort Pages { get { return _pages; } set {  _pages = value; } }
        public string Title { get { return _title; } set { _title = value; } }
    }
}
