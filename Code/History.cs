using System;

namespace Dummy_Database
{
    class History
    {
        public uint IdBook { get; set; }
        public uint IdReader { get; set; }
        public DateTime TookBook { get; set; }

        public History(uint idBook, uint idReader, string tookBook)
        {
            IdBook = idBook;
            IdReader= idReader;
            TookBook= Convert.ToDateTime(tookBook);
        }

        public static History[] CreateHistory(string[][] dataHistory)
        {
            dataHistory = dataHistory[1..];
            History[] result = new History[dataHistory.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = new History(
                    uint.Parse(dataHistory[i][0]),
                    uint.Parse(dataHistory[i][1]),
                    dataHistory[i][2]
                    );

            return result;
        }

        public static uint GetUserID(History[] arrayHistory, uint bookId)
        {
            foreach (History history in arrayHistory)
                if (history.IdBook == bookId)
                    return history.IdReader;
            throw new Exception($"Book id: {bookId} - \"There is not history with this book!\"");
        }

        public static string GetDateTookBook(History[] arrayHistory, uint readerId)
        {
            foreach (History history in arrayHistory)
                if (history.IdReader == readerId)
                    return history.TookBook.ToShortDateString();
            throw new Exception($"Reader id: {readerId} - \"Date not found!\"");
        }
    }
}
