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

            int[] lengthColumns = GetMaxLegthColumns(arrayBooks, arrayPersons, arrayHistory);

            Console.WriteLine($"|{"Автор".PadRight(lengthColumns[0])}|{"Название".PadRight(lengthColumns[1])}|{"Читатель".PadRight(lengthColumns[2])}|{"Взял".PadRight(lengthColumns[3])}|");
            Console.WriteLine($"|{new string('-', lengthColumns[0])}|{new string('-', lengthColumns[1])}|{new string('-', lengthColumns[2])}|{new string('-', lengthColumns[3])}|");

            foreach (Book book in arrayBooks)
            {
                string readerFullName = "";
                string date = "";

                if (book.IsUsed)
                {
                    uint readerId = History.GetUserID(arrayHistory, book.Id);
                    readerFullName = Person.GetFullNameReader(arrayPersons, readerId);
                    date = History.GetDateTookBook(arrayHistory, readerId);
                }
                Console.WriteLine($"|{book.Author.PadRight(lengthColumns[0])}|{book.Name.PadRight(lengthColumns[1])}|{readerFullName.PadRight(lengthColumns[2])}|{date.PadRight(lengthColumns[3])}|");
            }
        }

        private static int[] GetMaxLegthColumns(Book[] arrayBooks, Person[] arrayPersons, History[] arrayHistory)
        {
            int[] result = new int[] { 10, 10, 10, 10 };

            foreach (Book book in arrayBooks)
            {
                result[0] = Math.Max(result[0], book.Author.Length);
                result[1] = Math.Max(result[1], book.Name.Length);
            }

            foreach (Person person in arrayPersons)
                result[2] = Math.Max(result[2], person.FullName.Length);

            return result;
        }
    }
}
