using RockPaperScissors.Business.Business;
using RockPaperScissors.CrossCutting.Builder;
using RockPaperScissors.CrossCutting.Mapper;
using System;

namespace RockPaperScissors
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tournament");

            var playersDTO = new PlayerListBuilder().BuildTournament();
            var players = MapperDto2Player.Mapper(playersDTO);
            var confrontation = new ConfrontationService();
            var tournament = new TournamentService();

            tournament.Start(confrontation.PrepareClashes(players));

            //Descomentar para jogar mano a mano
            //Console.WriteLine("Single Confrontation");
            //playersDTO = new PlayerListBuilder().BuildSingleConfrontation();
            //players = MapperDto2Player.Mapper(playersDTO);
            //confrontation = new ConfrontationService();
            //tournament = new TournamentService();
            //tournament.Start(confrontation.PrepareClashes(players));

            Console.ReadKey();
        }
    }
}