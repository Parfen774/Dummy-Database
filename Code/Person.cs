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

        public static string GetFullNameReader(Person[] arrayPersons, uint readerId)
        {
            foreach (Person person in arrayPersons)
                if (person.Id == readerId)
                    return person.FullName;
            throw new Exception($"Reader id: {readerId} - \"Reader not found!\"");
        }
    }
}