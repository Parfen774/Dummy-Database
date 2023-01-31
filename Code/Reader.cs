namespace Dummy_Database
{
    internal class Reader
    {
        public uint Id { get; set; }
        public string Fullname { get; set; }

        public Reader (uint id, string fullname)
        {
            Id = id;
            Fullname = fullname;
        }
    }
}
