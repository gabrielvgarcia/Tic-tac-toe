using Tic_tac_toe.Domain.Entities;

namespace Tic_tac_toe.Domain.Contracts
{
    public interface IGameService
    {
        public void StartGame(Game game);
        public bool ValidateGameStatus(Game game);
        public void PrintGreeting();
        public string ReadInput(Game game);
        public string ValidateMove(Game game, string move);
    }
}
