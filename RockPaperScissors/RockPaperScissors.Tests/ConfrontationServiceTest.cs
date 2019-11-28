using NUnit.Framework;
using RockPaperScissors.Business.Business;
using RockPaperScissors.Business.Interface;
using RockPaperScissors.Domain.Enum;
using RockPaperScissors.Tests.Helper;

namespace RockPaperScissors.Tests
{
    public class ConfrontationServiceTest
    {
        private IConfrontationService _confrontationService;

        [SetUp]
        public void Setup()
        {
            _confrontationService = new ConfrontationService();
        }

        [Test]
        [TestCase(Movement.Paper, Movement.Paper, ExpectedResult = "Michael")]
        [TestCase(Movement.Rock, Movement.Scissors, ExpectedResult = "Michael")]
        [TestCase(Movement.Paper, Movement.Scissors, ExpectedResult = "Allen")]
        public string VencedorTest(Movement m1, Movement m2)
        {
            var player1 = TestHelper.BuildPlayer("Michael", m1);
            var player2 = TestHelper.BuildPlayer("Allen", m2);
            var winnner = _confrontationService.GetWinner(player1, player2);

            return winnner.Name;
        }

        [Test]
        public void Deve_preparar_confrontos_corretamente()
        {
            var list = TestHelper.BuildPlayerList();
            var clashes = _confrontationService.PrepareClashes(list);

            Assert.IsTrue(clashes.Count == 2);
        }
    }
}