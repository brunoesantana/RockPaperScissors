using RockPaperScissors.CrossCutting.DTO;
using RockPaperScissors.CrossCutting.Helpers;
using RockPaperScissors.Domain.Entity;
using RockPaperScissors.Domain.Enum;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.CrossCutting.Mapper
{
    public static class MapperDto2Player
    {
        public static IList<Player> Mapper(IList<PlayerDTO> dtoList)
        {
            var playerList = new List<Player>();

            dtoList.ToList().ForEach(f => {
                playerList.Add(new Player(f.Name, EnumHelper.GetEnumFromDescription<Movement>(f.Movement.ToUpper())));
            });

            return playerList;
        }
    }
}