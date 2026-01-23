using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    public class Borrower
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Borrower(string name, string cardNumber)
        {
            Name = name;
            LibraryCardNumber = cardNumber;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!BorrowedBooks.Contains(book))
                BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
                BorrowedBooks.Remove(book);
        }
    }
}
