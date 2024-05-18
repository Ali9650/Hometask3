

namespace Library
{
    internal class Library
    {
        public Library(Book book)
        {
            books = new Book[0];
            AddBook(book);
            RemoveBook(book);

        }
        private Book[] books;
        public Book[] Books { get => books; }

        public int Limit { get; } = 100;

        public Library()
        {
            books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            if (Limit >= books.Length)
            {
                books[books.Length - 1] = book;
            }
            else
            {
                Console.WriteLine("Kirabxanada yer yoxdur");
            }
        }

        public void GetBooks()
        {
            if (books is not null)
            {
                foreach (Book bk in books)
                {
                    Console.WriteLine($"{bk.Name} {bk.Type} {bk.Number}");
                }
            }
        }

        public void RemoveBook(Book book)
        {
            var index = Array.IndexOf(books, book);
            if (index != -1)
            {
                for (int i = index + 1; i < books.Length; i++)
                {
                    books[i - 1] = books[i];
                }
                books[books.Length - 1] = null;
                Array.Resize(ref books, books.Length - 1);
            }
        }
    }
}





