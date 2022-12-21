using System;
using System.Collections.Generic;
using Dummy_Database;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() 
            {
                new Book("Фёдор Достоевский", "Преступление и наказание", 1866, 1, 1),
                new Book("Иоганн Вольфганг фон Гёте", "Фауст", 1829, 1, 2)
            };

            List<Reader> readers = new List<Reader>()
            {
                new Reader(1, "Пупкин Вася"),
                new Reader(2, "Головач Лена")
            };
        }
    }
}