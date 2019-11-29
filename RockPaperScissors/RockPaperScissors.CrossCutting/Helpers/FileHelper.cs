using RockPaperScissors.CrossCutting.Exceptions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RockPaperScissors.CrossCutting.Helpers
{
    public static class FileHelper
    {
        public static IList<string> ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileException("File not found");

            var players = new List<string>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        players.Add(line);
                }
            }

            if (!players.Any())
                throw new FileException("Empty file");

            return players;
        }

        public static string GetFilePath(string fileName)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return $"{path}{fileName}";
        }
    }
}