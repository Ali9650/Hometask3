namespace Library
{
    internal class Program
    {
        static void Main()
        {
            Book book = new Book("Riyaziyyat", "Derslik", 5);
            Book book1 = new Book("Edebiyyat", "Derslik", 7);
            Book book2 = new Book("Qarmaqarisiq", "Dedektiv", 10);


            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.RemoveBook(book);

            library.GetBooks();
        }
    }
}
