using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dummy_Database
{
    class Scheme
    {
        public string Name { get; set; }
        public JArray Columns { get; set; }

        public Scheme(string path)
        {
            JObject jsonScheme = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(path));

            Name = jsonScheme["name"].ToString();
            Columns = (JArray)jsonScheme["columns"];
        }
    }
}