using RockPaperScissors.Business.Interface;
using RockPaperScissors.CrossCutting.Validations;
using RockPaperScissors.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Business.Business
{
    public class TournamentService : ITournamentService
    {
        private readonly IConfrontationService _confrontationService;

        public TournamentService()
        {
            _confrontationService = new ConfrontationService();
        }

        public string Start(IList<Confrontation> clashes)
        {
            var newPlayerList = new List<Player>();

            while (clashes.Count == 1 || clashes.Count % 2 == 0)
            {
                foreach (var item in clashes)
                {
                    ConfrontationValidation.ValidateConfrontation(item.Player1, item.Player2);
                    newPlayerList.Add(_confrontationService.GetWinner(item.Player1, item.Player2));
                }

                if (newPlayerList.Count == 1)
                    break;

                clashes.Clear();
                clashes = _confrontationService.PrepareClashes(newPlayerList).ToList();

                newPlayerList.Clear();
            }

            var winner = newPlayerList.First();

            Console.WriteLine($"Winner of tournament - {winner.Name}");

            return winner.Name;
        }
    }
}