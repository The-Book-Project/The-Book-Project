namespace TheBookProject.Services.Data
{
    using Contracts;
    using System.Linq;
    using TheBookProject.Data.Common;
    using TheBookProject.Data.Models;

    public class BookService : IBookService
    {
        private readonly IDbRepository<Book> books;

        public BookService(IDbRepository<Book> books)
        {
            this.books = books;
        }

        public IQueryable<Book> AllBooks()
        {
            return this.books.All();
        }

        public int AllAddedBooks()
        {
            return this.books.All().Count();
        }

        public IQueryable<Book> AllBooksWithDeleted()
        {
            return this.books.AllWithDeleted();
        }

        public Book GetById(object id)
        {
            return this.books.GetById(id);
        }

        public void DeleteBook(Book book)
        {
            this.books.Delete(book);
            this.books.Save();
        }

        public void HardDeleteBook(Book book)
        {
            this.books.HardDelete(book);
            this.books.Save();
        }

        public void DeleteBookById(object id)
        {
            var book = this.books.GetById(id);
            this.books.Delete(book);
            this.books.Save();
        }

        public void HardDeleteBookById(object id)
        {
            var book = this.books.GetById(id);
            this.books.HardDelete(book);
            this.books.Save();
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
            this.books.Save();
        }
    }
}
