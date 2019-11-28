using System.ComponentModel;

namespace RockPaperScissors.Domain.Enum
{
    public enum Movement
    {
        [Description("R")]
        Rock,

        [Description("P")]
        Paper,

        [Description("S")]
        Scissors
    }
}