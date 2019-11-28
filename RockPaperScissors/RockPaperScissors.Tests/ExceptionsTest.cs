using NUnit.Framework;
using RockPaperScissors.CrossCutting.Exceptions;
using RockPaperScissors.CrossCutting.Helpers;
using RockPaperScissors.CrossCutting.Validations;
using RockPaperScissors.Domain.Enum;
using RockPaperScissors.Tests.Helper;

namespace RockPaperScissors.Tests
{
    public class ExceptionsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_lancar_excecao_se_houver_movimento_invalido()
        {
            var ex = Assert.Throws<MovementException>(() => EnumHelper.GetEnumFromDescription<Movement>("Y"));
            Assert.AreEqual(ex.Message, "Invalid moves Y");
        }

        [Test]
        public void Deve_lancar_excecao_se_numero_de_particiantes_for_invalido()
        {
            var ex = Assert.Throws<NumberPlayersException>(() => NumberOfPlayerValidation.ValidateNumberOfPlayers(TestHelper.BuildInvalidPlayerList()));
            Assert.AreEqual(ex.Message, "Invalid number of players");
        }
    }
}