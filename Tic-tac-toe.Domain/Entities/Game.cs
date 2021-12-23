namespace Tic_tac_toe.Domain.Entities
{
    public class Game
    {
        public int Moves { get; set; }
        public string CurrentPlayer { get; set; }
        public Matrix Matrix { get; set; }

        public Game(string currentPlayer, Matrix matrix)
        {
            Moves = 1;
            CurrentPlayer = currentPlayer;
            Matrix = matrix;
        }
    }
}
