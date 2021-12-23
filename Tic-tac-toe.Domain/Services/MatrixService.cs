using System;
using Tic_tac_toe.Domain.Contracts;
using Tic_tac_toe.Domain.Entities;

namespace Tic_tac_toe.Domain.Services
{
    public class MatrixService : IMatrixService
    {
        public void PrintMatrix(Game game)
        {
            for (int i = 0; i < game.Matrix.MatrixSize.GetLength(0); i++)
            {
                for (int j = 0; j < game.Matrix.MatrixSize.GetLength(1); j++)
                {
                    Console.Write($" [{game.Matrix.MatrixSize[i, j]}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Please enter a number corresponding to a tic-tac-toe position above.");
        }

        public Game RenderMatrix(Game game)
        {
            for (int i = 0; i < game.Matrix.MatrixSize.GetLength(0); i++)
            {
                for (int j = 0; j < game.Matrix.MatrixSize.GetLength(1); j++)
                {
                    game.Matrix.MatrixSize[i, j] = game.Matrix.Index.ToString();

                    game.Matrix.IndexNumbers.Add(game.Matrix.Index.ToString());

                    game.Matrix.Index++;
                }
            }

            return game;
        }

        public Game ReplaceValue(Game game, string currentMove)
        {
            for (int i = 0; i < game.Matrix.MatrixSize.GetLength(0); i++)
            {
                for (int j = 0; j < game.Matrix.MatrixSize.GetLength(1); j++)
                {
                    if (game.Matrix.MatrixSize[i, j] == currentMove && game.Matrix.IndexNumbers.Contains(currentMove))
                    {
                        game.Matrix.MatrixSize[i, j] = game.CurrentPlayer;
                        game.Matrix.IndexNumbers.Remove(currentMove);
                    }
                }
            }

            return game;
        }
    }
}
