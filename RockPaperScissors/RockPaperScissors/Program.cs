using RockPaperScissors.Business.Business;
using RockPaperScissors.CrossCutting.Builder;
using RockPaperScissors.CrossCutting.Helpers;
using System;

namespace RockPaperScissors
{
    public class Program
    {
        private const string VALID_INPUT_FILE = @"\Resources\valid_input.txt";

        private static void Main(string[] args)
        {
            Console.WriteLine("Tournament");

            var stringPlayersList = FileHelper.ReadFile(FileHelper.GetFilePath(VALID_INPUT_FILE));
            var players = new PlayerListBuilder().Build(stringPlayersList);
            
            new TournamentService().Start(new ConfrontationService().PrepareClashes(players));

            Console.ReadKey();
        }
    }
}