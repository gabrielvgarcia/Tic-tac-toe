using Tic_tac_toe.Domain.Entities;

namespace Tic_tac_toe.Domain.Contracts
{
    public interface IMatrixService
    {
        public void PrintMatrix(Game game);
        public Game RenderMatrix(Game game);
        public Game ReplaceValue(Game game, string currentMove);
    }
}
