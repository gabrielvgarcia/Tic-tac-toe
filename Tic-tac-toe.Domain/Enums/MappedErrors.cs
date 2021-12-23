using System.ComponentModel;

namespace Tic_tac_toe.Domain.Enums
{
    public enum MappedErrors
    {
        [Description("the player name is too long, use up to 20 characters")] PLAYER_TOO_LONG_NAME = 1,
        [Description("Invalid play. Try again: ")] INVALID_PLAY = 2
    }
}
