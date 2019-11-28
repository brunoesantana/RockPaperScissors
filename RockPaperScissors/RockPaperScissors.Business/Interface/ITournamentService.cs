using RockPaperScissors.Domain.Entity;
using System.Collections.Generic;

namespace RockPaperScissors.Business.Interface
{
    public interface ITournamentService
    {
        string Start(IList<Confrontation> clashes);
    }
}