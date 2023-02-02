using System;

namespace Dummy_Database
{
    internal class Person
    {
        public uint Id { get; set; }
        public string FullName { get; set; }

        public Person (uint id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public static Person[] CreatePersons(string[][] dataPersons)
        {
            dataPersons = dataPersons[1..];
            Person[] result = new Person[dataPersons.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = new Person(
                    uint.Parse(dataPersons[i][0]),
                    dataPersons[i][1]);

            return result;
        }

        public static uint FindReaderIdByBookID(Person[] arrayPersons, History[] arrayHistory, uint bookID)
        {
            foreach (History history in arrayHistory)
                if (history.IdBook == bookID)
                    return history.IdReader;
            throw new Exception($"ID: {bookID} - \"Dont have book!\"");
        }

        public static string FindFullNameByReaderID(Person[] arrayPersons, uint readerID)
        {
            foreach (Person person in arrayPersons)
                if (person.Id == readerID)
                    return person.FullName;
            throw new Exception($"ID: {readerID} - \"Dont have book!\"");
        }

        public static string FindDateByReaderID(History[] arrayHistory, uint readerID)
        {
            foreach (History history in arrayHistory)
                if (history.IdReader == readerID)
                    return history.TookBook.ToShortDateString();
            throw new Exception($"ID: {readerID} - \"Dont have book!\"");
        }
    }
}