namespace Perpustakaan.Services.BookServices
{
    public class BookServices : IBookServices
    {
        private static List<BookClass> BookClass = new List<BookClass>
        {
            new BookClass
            {
                id = 1,
                judul = "Conan",
                penerbit = "GrandMedia",
                penulis = "Ryan",
                genre = "action"
            },
            new BookClass
            {
                id = 2,
                judul = "One Pice",
                penerbit = "GrandMedia",
                penulis = "Tian",
                genre = "action, komedi"
            }
        };

        public List<BookClass> AddBook(BookClass book)
        {
            BookClass.Add(book);
            return BookClass;
        }

        public List<BookClass>? DeleteBook(int Id)
        {
            var book = BookClass.Find(x => x.id == Id);
            if (book is null)
                return null;

            BookClass.Remove(book);
            return BookClass;
        }

        public List<BookClass> GetAllBook()
        {
            return BookClass;
        }

        public BookClass? GetSingleBook(int Id)
        {
            var book = BookClass.Find(x => x.id == Id);
            if (book is null)
            {
                return null;
            }

            return book;
        }

        public List<BookClass>? UpdateBook(int Id, BookClass request)
        {
            var book = BookClass.Find(x => x.id == Id);
            if (book is null)
                return null;

            book.judul = request.judul;
            book.penerbit = request.penerbit;
            book.penulis = request.penulis;
            book.genre = request.genre;

            return BookClass;
        }
    }
}
