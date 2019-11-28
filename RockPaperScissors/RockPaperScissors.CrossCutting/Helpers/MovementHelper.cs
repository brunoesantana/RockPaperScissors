using RockPaperScissors.Domain.Enum;

namespace RockPaperScissors.CrossCutting.Helpers
{
    public static class MovementHelper
    {
        public static Movement WhoMovementWins(Movement movement)
        {
            return movement switch
            {
                Movement.Rock => Movement.Paper,

                Movement.Paper => Movement.Scissors,

                _ => Movement.Rock,
            };
        }
    }
}