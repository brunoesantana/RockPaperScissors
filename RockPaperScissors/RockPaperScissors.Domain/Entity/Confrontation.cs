namespace RockPaperScissors.Domain.Entity
{
    public class Confrontation
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Confrontation()
        {
        }

        public Confrontation(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}