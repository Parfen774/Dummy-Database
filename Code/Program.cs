using System;

namespace Dummy_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] dataBooks = ReaderCSV.ReadCSV(@"CSV/Books.csv");
            Scheme schemeBook = new Scheme(@"JSON/Book.json");

            Console.WriteLine(ReaderCSV.CheckCorrectData(schemeBook, dataBooks));
        }
    }
}