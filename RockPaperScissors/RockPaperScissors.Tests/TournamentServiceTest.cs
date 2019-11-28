using NUnit.Framework;
using RockPaperScissors.Business.Business;
using RockPaperScissors.Business.Interface;
using RockPaperScissors.CrossCutting.Builder;
using RockPaperScissors.CrossCutting.Mapper;

namespace RockPaperScissors.Tests
{
    public class TournamentServiceTest
    {
        private IConfrontationService _confrontationService;
        private ITournamentService _tournamentService;

        private PlayerListBuilder _playerListBuilder;

        [SetUp]
        public void Setup()
        {
            _confrontationService = new ConfrontationService();
            _tournamentService = new TournamentService();
            _playerListBuilder = new PlayerListBuilder();
        }

        [Test]
        public void Deve_retornar_vencedor_do_torneio_corretamente()
        {
            var playersDTO = _playerListBuilder.BuildTournament();
            var players = MapperDto2Player.Mapper(playersDTO);

            var winner = _tournamentService.Start(_confrontationService.PrepareClashes(players));

            Assert.AreEqual(winner, "Richard");
        }

        [Test]
        public void Deve_retornar_vencedor_de_confronto_simples()
        {
            var playersDTO = _playerListBuilder.BuildSingleConfrontation();
            var players = MapperDto2Player.Mapper(playersDTO);

            var winner = _tournamentService.Start(_confrontationService.PrepareClashes(players));

            Assert.AreEqual(winner, "Dave");
        }
    }
}