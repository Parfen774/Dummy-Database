using System;

namespace Dummy_Database
{
    internal class Book
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
    }
}
