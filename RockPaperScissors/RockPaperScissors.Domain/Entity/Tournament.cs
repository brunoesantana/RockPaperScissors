using System.Collections.Generic;

namespace RockPaperScissors.Domain.Entity
{
    public class Tournament
    {
        public IList<Player> Players { get; set; }

        public Tournament()
        {
        }

        public Tournament(IList<Player> players)
        {
            Players = players;
        }
    }
}