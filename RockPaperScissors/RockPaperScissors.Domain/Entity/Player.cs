using RockPaperScissors.Domain.Enum;

namespace RockPaperScissors.Domain.Entity
{
    public class Player
    {
        public Player()
        {
        }

        public Player(string name, Movement movement)
        {
            Name = name;
            Movement = movement;
        }

        public string Name { get; set; }

        public Movement Movement { get; set; }
    }
}