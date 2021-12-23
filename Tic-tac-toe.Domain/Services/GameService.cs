﻿using System;
using System.Linq;
using Tic_tac_toe.Domain.Contracts;
using Tic_tac_toe.Domain.Entities;
using Tic_tac_toe.Domain.Enums;
using Tic_tac_toe.Domain.Extensions;

namespace Tic_tac_toe.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly IMatrixService matrixService;

        public GameService(IMatrixService matrixService)
        {
            this.matrixService = matrixService;
        }

        public void StartGame(Game game)
        {
            PrintGreeting();

            game = matrixService.RenderMatrix(game);

            matrixService.PrintMatrix(game);

            string currentMove = ReadInput(game);

            Console.Clear();

            while (game.Moves < game.Matrix.MatrixSize.Length)
            {
                PrintGreeting();

                //Substituir o valor na sua respectiva casa
                game = matrixService.ReplaceValue(game, currentMove);

                //Imprimir a matriz
                matrixService.PrintMatrix(game);

                if (ValidateGameStatus(game))
                {
                    Console.WriteLine();
                    Console.WriteLine("Fim de jogo");
                    Console.WriteLine($"Parabéns, o ganhador é {game.CurrentPlayer}");
                    break;
                }

                if (game.CurrentPlayer == EnumPlayerType.X.ToString())
                    game.CurrentPlayer = EnumPlayerType.O.ToString();
                else
                    game.CurrentPlayer = EnumPlayerType.X.ToString();

                currentMove = ReadInput(game);

                game.Moves++;

                Console.Clear();
            }

            if (game.Moves == game.Matrix.MatrixSize.Length)
                Console.WriteLine("Ninguém ganhou!");

            Console.ReadLine();
        }
        public bool ValidateGameStatus(Game game)
        {
            for (int i = 0; i < game.Matrix.MatrixSize.GetLength(0); i++)
            {
                // Check all rows 
                string[] rows = game.Matrix.MatrixSize.GetRow(i);

                // Check all columns
                string[] columns = game.Matrix.MatrixSize.GetColumn(i);

                // Check primary diagonal
                string[] primary = game.Matrix.MatrixSize.GetDiagonal(axis: "x");

                // Check secondary diagonal
                string[] secondary = game.Matrix.MatrixSize.GetDiagonal(axis: "y");

                if (rows.Distinct().Count() == 1 ||
                       columns.Distinct().Count() == 1 ||
                       primary.Distinct().Count() == 1 ||
                       secondary.Distinct().Count() == 1)
                    return true;
            }
            return false;
        }
        public void PrintGreeting()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("          Tic Tac Toe          ");
            Console.WriteLine("-------------------------------");
        }
        public string ReadInput(Game game)
        {
            Console.WriteLine();
            Console.Write($"Type the next move of player --{game.CurrentPlayer}--: ");
            string move = Console.ReadLine();

            move = ValidateMove(game, move);

            return move;
        }
        public string ValidateMove(Game game, string move)
        {
            while (!game.Matrix.IndexNumbers.Contains(move))
            {
                Console.WriteLine();

                Console.Write(MappedErrors.INVALIDPLAY.GetDescription());

                move = Console.ReadLine();
            }

            return move;
        }
    }
}
