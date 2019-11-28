using RockPaperScissors.CrossCutting.Exceptions;
using RockPaperScissors.Domain.Entity;
using RockPaperScissors.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.CrossCutting.Validations
{
    public static class ConfrontationValidation
    {
        public static void ValidateConfrontation(Player player1, Player player2)
        {
            var list = new List<Player> { player1, player1 };

            if (GetMovementErrorList(list).Any())
                throw new MovementException("There are players with invalid moves");
        }

        private static IList<Player> GetMovementErrorList(IList<Player> players)
        {
            return players.Where(w => !w.Movement.ToString().Contains(Movement.Rock.ToString())
            && !w.Movement.ToString().Contains(Movement.Paper.ToString())
            && !w.Movement.ToString().Contains(Movement.Scissors.ToString())).ToList();
        }
    }
}