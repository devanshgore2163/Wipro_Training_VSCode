using NUnit.Framework;
using LibraryManagement;

namespace LibraryManagement.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        private Library _library;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBook()
        {
            var book = new Book("C#", "John", "101");
            _library.AddBook(book);
            Assert.That(_library.Books.Count, Is.EqualTo(1)); // <-- NUnit syntax
        }

        [Test]
        public void BorrowBook_ShouldMarkBorrowed()
        {
            var book = new Book("C#", "John", "101");
            var borrower = new Borrower("Dev", "LC01");
            _library.AddBook(book);
            _library.RegisterBorrower(borrower);

            _library.BorrowBook("101", "LC01");
            Assert.That(book.IsBorrowed, Is.True); // <-- NUnit syntax
        }

        [Test]
        public void ReturnBook_ShouldMakeAvailable()
        {
            var book = new Book("C#", "John", "101");
            var borrower = new Borrower("Dev", "LC01");
            _library.AddBook(book);
            _library.RegisterBorrower(borrower);
            _library.BorrowBook("101", "LC01");

            _library.ReturnBook("101", "LC01");
            Assert.That(book.IsBorrowed, Is.False); // <-- NUnit syntax
        }
    }
}
