namespace Perpustakaan.Services.BookServices
{
    public interface IBookServices
    {
        List<BookClass> GetAllBook();
        BookClass? GetSingleBook(int Id);
        List<BookClass> AddBook(BookClass book);
        List<BookClass>? UpdateBook(int Id, BookClass request);
        List<BookClass>? DeleteBook(int Id);
    }
}
