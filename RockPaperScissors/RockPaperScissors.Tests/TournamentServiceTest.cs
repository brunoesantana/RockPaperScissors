using NUnit.Framework;
using RockPaperScissors.Business.Business;
using RockPaperScissors.Business.Interface;
using RockPaperScissors.CrossCutting.Builder;
using RockPaperScissors.Tests.Helper;

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
            var players = _playerListBuilder.Build(TestHelper.BuildTournamentStringPlayerList());
            var winner = _tournamentService.Start(_confrontationService.PrepareClashes(players));

            Assert.AreEqual(winner, "Richard");
        }

        [Test]
        public void Deve_retornar_vencedor_de_confronto_simples()
        {
            var players = _playerListBuilder.Build(TestHelper.BuildSimpleStringPlayerList());
            var winner = _tournamentService.Start(_confrontationService.PrepareClashes(players));

            Assert.AreEqual(winner, "Dave");
        }
    }
}