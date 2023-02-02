using System;
using System.IO;

namespace Dummy_Database
{
    static class ReaderCSV
    {
        public static string[][] ReadCSV(string path)
        {
            string[] allLines = File.ReadAllLines(path);
            string[][] result = new string[allLines.Length][];

            for (int i = 0; i < allLines.Length; i++)
                result[i] = allLines[i].Split(';');

            return result;
        }
        
        public static bool CheckCorrectData(Scheme scheme, string[][] data)
        {
            for (int row = 1; row < data.Length; row++)
                for (int column = 0; column < data[0].Length; column++)
                {
                    string value = data[row][column].ToString();
                    string type = scheme.Columns[column]["type"].ToString();

                    switch (type)
                    {
                        case "int":
                            if (!int.TryParse(value, out int num))
                                throw new Exception($"Incorrect \"{scheme.Columns[column]["name"]}\"! Line: {row + 1}, Column: {column + 1}");
                            break;
                        case "uint":
                            if (!uint.TryParse(value, out uint unum))
                                throw new Exception($"Incorrect \"{scheme.Columns[column]["name"]}\"! Line: {row + 1}, Column: {column + 1}");
                            break;
                        case "bool":
                            if (!bool.TryParse(value, out bool boolean))
                                throw new Exception($"Incorrect \"{scheme.Columns[column]["name"]}\"! Line: {row + 1}, Column: {column + 1}");
                            break;
                    }
                }
            return true;
        }
    }
}