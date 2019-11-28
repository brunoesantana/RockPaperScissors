using NUnit.Framework;
using RockPaperScissors.CrossCutting.Builder;
using RockPaperScissors.CrossCutting.Mapper;
using System.Linq;

namespace RockPaperScissors.Tests
{
    public class MapperDto2PlayerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_mapear_lista_corretamente()
        {
            var dtoList = new PlayerListBuilder().BuildSingleConfrontation();
            var playerList = MapperDto2Player.Mapper(dtoList);

            Assert.IsTrue(dtoList.Any());
            Assert.IsTrue(playerList.Any());
            Assert.AreEqual(dtoList.Count, playerList.Count);
        }
    }
}