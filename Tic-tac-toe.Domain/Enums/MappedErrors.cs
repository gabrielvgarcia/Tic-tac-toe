using System.ComponentModel;

namespace Tic_tac_toe.Domain.Enums
{
    public enum MappedErrors
    {
        [Description("Invalid move. Try again: ")] 
        INVALIDPLAY = 1,

        [Description("It's a tie!")]
        TIERESULT = 2
    }
}
