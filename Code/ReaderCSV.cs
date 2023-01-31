using System;
using System.IO;

namespace Dummy_Database
{
    static class ReaderCSV
    {
        public static string[][] ReadCSV(string path)
        {
            string[] allLines = File.ReadAllLines(path)[1..];
            string[][] result = new string[allLines.Length][];

            for (int i = 0; i < allLines.Length; i++)
                result[i] = allLines[i].Split(';');

            return result;
        }
    }
}