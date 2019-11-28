using NUnit.Framework;
using RockPaperScissors.CrossCutting.Helpers;
using RockPaperScissors.Domain.Enum;

namespace RockPaperScissors.Tests
{
    public class EnumHelperTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_retornar_enum_paper()
        {
            var result = EnumHelper.GetEnumFromDescription<Movement>("P");
            Assert.AreEqual(Movement.Paper, result);
        }

        [Test]
        public void Deve_retornar_enum_rock()
        {
            var result = EnumHelper.GetEnumFromDescription<Movement>("R");
            Assert.AreEqual(Movement.Rock, result);
        }

        [Test]
        public void Deve_retornar_enum_scissors()
        {
            var result = EnumHelper.GetEnumFromDescription<Movement>("S");
            Assert.AreEqual(Movement.Scissors, result);
        }
    }
}