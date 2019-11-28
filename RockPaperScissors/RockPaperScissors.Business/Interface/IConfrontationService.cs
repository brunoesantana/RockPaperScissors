using RockPaperScissors.Domain.Entity;
using System.Collections.Generic;

namespace RockPaperScissors.Business.Interface
{
    public interface IConfrontationService
    {
        Player GetWinner(Player player1, Player player2);

        IList<Confrontation> PrepareClashes(IList<Player> players);
    }
}