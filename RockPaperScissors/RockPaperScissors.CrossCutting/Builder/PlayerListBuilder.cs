using RockPaperScissors.CrossCutting.Helpers;
using RockPaperScissors.Domain.Entity;
using RockPaperScissors.Domain.Enum;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.CrossCutting.Builder
{
    public class PlayerListBuilder
    {
        public IList<Player> Build(IList<string> stringPlayersList)
        {
            var playerList = new List<Player>();

            stringPlayersList.ToList().ForEach(f =>
            {
                var player = f.Split(",");
                playerList.Add(new Player(player.First(), EnumHelper.GetEnumFromDescription<Movement>(player.Last().ToUpper())));
            });

            return playerList;
        }
    }
}