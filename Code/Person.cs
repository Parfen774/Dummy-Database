namespace Dummy_Database
{
    internal class Person
    {
        public uint Id { get; set; }
        public string Fullname { get; set; }

        public Person (uint id, string fullname)
        {
            Id = id;
            Fullname = fullname;
        }
    }
}
