using NUnit.Framework;
using RockPaperScissors.CrossCutting.Helpers;
using RockPaperScissors.Domain.Enum;

namespace RockPaperScissors.Tests
{
    public class MovementHelperTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_retornar_papel_se_pedra_for_selecionado()
        {
            var winnner = MovementHelper.WhoMovementWins(Movement.Rock);
            Assert.AreEqual(Movement.Paper, winnner);
        }

        [Test]
        public void Deve_retornar_tesoura_se_papel_for_selecionado()
        {
            var winnner = MovementHelper.WhoMovementWins(Movement.Paper);
            Assert.AreEqual(Movement.Scissors, winnner);
        }

        [Test]
        public void Deve_retornar_pedra_se_tesoura_for_selecionado()
        {
            var winnner = MovementHelper.WhoMovementWins(Movement.Scissors);
            Assert.AreEqual(Movement.Rock, winnner);
        }
    }
}