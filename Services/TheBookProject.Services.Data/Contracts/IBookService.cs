namespace TheBookProject.Services.Data.Contracts
{
    using System.Linq;

    using TheBookProject.Data.Models;

    public interface IBookService
    {
        IQueryable<Book> AllBooks();

        int AllAddedBooks();

        IQueryable<Book> AllBooksWithDeleted();

        Book GetById(object id);

        void DeleteBook(Book book);

        void HardDeleteBook(Book book);

        void DeleteBookById(object id);

        void HardDeleteBookById(object id);

        void AddBook(Book book);
    }
}
