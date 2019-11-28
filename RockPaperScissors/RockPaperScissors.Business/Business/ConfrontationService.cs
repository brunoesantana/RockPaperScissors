using RockPaperScissors.Business.Interface;
using RockPaperScissors.CrossCutting.Helpers;
using RockPaperScissors.CrossCutting.Validations;
using RockPaperScissors.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Business.Business
{
    public class ConfrontationService : IConfrontationService
    {
        public Player GetWinner(Player player1, Player player2)
        {
            if (player2 == null)
                return player1;

            if (player1.Movement.Equals(player2.Movement))
            {
                WriteLine(player1, player2);
                return player1;
            }

            if (MovementHelper.WhoMovementWins(player2.Movement).Equals(player1.Movement))
            {
                WriteLine(player1, player2);
                return player1;
            }

            if (MovementHelper.WhoMovementWins(player1.Movement).Equals(player2.Movement))
            {
                WriteLine(player1, player2);
                return player2;
            }

            return null;
        }

        private void WriteLine(Player player1, Player player2)
        {
            Console.WriteLine($"Player {player1.Name} - {player1.Movement.ToString()}");
            Console.WriteLine($"Player {player2.Name} - {player2.Movement.ToString()}");
            Console.WriteLine("-----------------------");
        }

        public IList<Confrontation> PrepareClashes(IList<Player> players)
        {
            NumberOfPlayerValidation.ValidateNumberOfPlayers(players);

            var clashes = new List<Confrontation>();

            for (var i = 0; i < players.Count; i += 2)
            {
                if (players.Count == 1)
                {
                    clashes.Add(new Confrontation(players.First(), null));
                    return clashes;
                }

                clashes.Add(new Confrontation(players[i], players[(i + 1)]));
            }

            return clashes;
        }
    }
}