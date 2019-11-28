using RockPaperScissors.CrossCutting.Exceptions;
using RockPaperScissors.Domain.Entity;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.CrossCutting.Validations
{
    public static class NumberOfPlayerValidation
    {
        public static void ValidateNumberOfPlayers(IList<Player> players)
        {
            if (players.Count <= 1)
                throw new NumberPlayersException("Invalid number of players");

            for (int i = 0; i < players.Count; i++)
            {
                if (Math.Pow(2, i) == players.Count)
                    break;

                if (Math.Pow(2, i) > players.Count)
                    throw new NumberPlayersException("Invalid number of players");
            }
        }
    }
}