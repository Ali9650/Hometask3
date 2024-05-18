

namespace Library
{
    internal class Book
    {

        public Book (string name, string type, int number)
        {
            Name = name;
            Type = type;
            Number = number;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Number { get; set; }
    }


}
