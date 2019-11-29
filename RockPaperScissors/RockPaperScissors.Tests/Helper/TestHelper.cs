using RockPaperScissors.Domain.Entity;
using RockPaperScissors.Domain.Enum;
using System.Collections.Generic;

namespace RockPaperScissors.Tests.Helper
{
    public static class TestHelper
    {
        public static IList<Player> BuildInvalidPlayerList()
        {
            return new List<Player>
            {
                new Player("Armando", Movement.Rock),
                new Player("Dave", Movement.Paper),
                new Player("Richard", Movement.Scissors)
            };
        }

        public static IList<Player> BuildPlayerList()
        {
            return new List<Player>
            {
                new Player("Armando", Movement.Rock),
                new Player("Dave", Movement.Paper),
                new Player("Richard", Movement.Rock),
                new Player("Michael", Movement.Scissors)
            };
        }

        public static Player BuildPlayer(string name, Movement movement)
        {
            return new Player(name, movement);
        }

        public static IList<string> BuildTournamentStringPlayerList()
        {
            return new List<string>
            {
                "Armando,P",
                "Dave,S",
                "Richard,R",
                "Michael,S",
                "Allen,S",
                "Omer,P",
                "David E.,R",
                "Richard X.,P"
            };
        }

        public static IList<string> BuildSimpleStringPlayerList()
        {
            return new List<string> { "Armando,P", "Dave,S" };
        }
    }
}