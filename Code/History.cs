using System;

namespace Dummy_Database
{
    internal class History
    {
        public static uint IdBook { get; set; }
        public static uint IdReader { get; set; }
        public static DateTime TookBook { get; set; }
        public static DateTime ReturnBook { get; set; }

        public History(uint idBook, uint idReader, string tookBook, string returnBook)
        {
            IdBook= idBook;
            IdReader= idReader;
            TookBook= Convert.ToDateTime(tookBook);
            ReturnBook= Convert.ToDateTime(returnBook);
        }
    }
}
