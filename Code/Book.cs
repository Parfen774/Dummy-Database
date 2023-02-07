using System;

namespace Dummy_Database
{
    class Book
    {
        public uint Id { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public bool IsUsed { get; set; }
        public int Wardrobe { get; set; }
        public int Shelf { get; set; }

        public Book(uint id, string author, string name, int year, bool isUsed, int wardrobe, int shelf)
        {
            Id = id;
            Author = author;
            Name = name;
            Year = year;
            IsUsed = isUsed;
            Wardrobe = wardrobe;
            Shelf = shelf;
        }

        public static Book[] CreateBooks(string[][] dataBooks)
        {
            dataBooks = dataBooks[1..];
            Book[] result = new Book[dataBooks.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = new Book(
                    uint.Parse(dataBooks[i][0]),
                    dataBooks[i][1],
                    dataBooks[i][2],
                    int.Parse(dataBooks[i][3]),
                    bool.Parse(dataBooks[i][4]),
                    int.Parse(dataBooks[i][5]),
                    int.Parse(dataBooks[i][6]));

            return result;
        }

        public static void Print(History[] arrayHistory, Person[] arrayPersons, Book[] arrayBooks)
        {
            uint readerId = 0;
            string readerFullName = "";
            string date = "";

            foreach (Book book in arrayBooks)
            {
                if (book.IsUsed)
                {
                    readerId = History.GetUserID(arrayHistory, book.Id);
                    readerFullName = Person.GetFullNameReader(arrayPersons, readerId);
                    date = History.GetDateTookBook(arrayHistory, readerId);
                }
                Console.WriteLine($"{book.Author}, {book.Name}, {readerFullName}, {date}");
            }
        }
    }
}
