using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "SoccerGameResults.csv");

            var fileContents = ReadSoccerResults(fileName);
        }

        public static String ReadFile(String fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<String[]> ReadSoccerResults(String fileName)
        {
            var SoccerResults = new List<String[]>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var gameResult = new GameResult();
                    string[] values = line.Split(',');

                    try
                    {
                        gameResult.GameDate = DateTime.Parse(values[0], new CultureInfo("en-US"));
                    }
                    catch { }

                    Console.WriteLine(gameResult.GameDate);
                    SoccerResults.Add(values);
                }
            }

            return SoccerResults;
        }
    }

}
