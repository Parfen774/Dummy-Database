using System;

namespace Dummy_Database
{
    internal class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public bool IsUsed { get; set; }
        public int Wardrobe { get; set; }
        public int Shelf { get; set; }

        public Book(string author, string name, string year, bool isUsed, int wardrobe, int shelf)
        {
            Author = author;
            Name = name;
            Year = Convert.ToDateTime(year);
            IsUsed = isUsed;
            Wardrobe = wardrobe;
            Shelf = shelf;
        }
    }
}
