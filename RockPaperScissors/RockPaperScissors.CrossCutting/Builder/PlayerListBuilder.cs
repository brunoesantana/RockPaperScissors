using RockPaperScissors.CrossCutting.DTO;
using System.Collections.Generic;

namespace RockPaperScissors.CrossCutting.Builder
{
    public class PlayerListBuilder
    {
        public IList<PlayerDTO> BuildTournament()
        {
            return new List<PlayerDTO>
            {
                new PlayerDTO {Name = "Armando", Movement = "P" },
                new PlayerDTO {Name = "Dave", Movement = "S" },
                new PlayerDTO {Name = "Richard", Movement = "R" },
                new PlayerDTO {Name = "Michael", Movement = "S" },
                new PlayerDTO {Name = "Allen", Movement = "S" },
                new PlayerDTO {Name = "Omer", Movement = "P" },
                new PlayerDTO {Name = "David E.", Movement = "R" },
                new PlayerDTO {Name = "Richard X.", Movement = "P" }
            };
        }

        public IList<PlayerDTO> BuildSingleConfrontation()
        {
            return new List<PlayerDTO>
            {
                new PlayerDTO {Name = "Armando", Movement = "P" },
                new PlayerDTO {Name = "Dave", Movement = "S" },
            };
        }
    }
}