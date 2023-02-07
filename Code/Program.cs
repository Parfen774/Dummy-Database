namespace Dummy_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            // Так много кода для хорошо понимания работы классов...

            string[][] dataBooks = ReaderCSV.ReadCSV(@"CSV/Books.csv");
            Scheme schemeBook = new Scheme(@"JSON/Book.json");
            bool correctBooks = ReaderCSV.CheckCorrectData(schemeBook, dataBooks);

            string[][] dataPersons = ReaderCSV.ReadCSV(@"CSV/Readers.csv");
            Scheme schemePerson = new Scheme(@"JSON/Reader.json");
            bool correctPersons = ReaderCSV.CheckCorrectData(schemePerson, dataPersons);

            string[][] dataHistory = ReaderCSV.ReadCSV(@"CSV/History.csv");
            Scheme schemeHistory = new Scheme(@"JSON/History.json");
            bool correctHistory = ReaderCSV.CheckCorrectData(schemeHistory, dataHistory);

            if (correctBooks && correctPersons && correctHistory)
            {
                Book[] arrayBooks = Book.CreateBooks(dataBooks);
                Person[] arrayPersons = Person.CreatePersons(dataPersons);
                History[] arrayHistory = History.CreateHistory(dataHistory);

                Book.Print(arrayHistory, arrayPersons, arrayBooks);
            }
        }
    }
}