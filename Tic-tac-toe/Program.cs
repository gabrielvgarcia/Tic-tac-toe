using Microsoft.Extensions.DependencyInjection;
using Tic_tac_toe.Domain.Contracts;
using Tic_tac_toe.Domain.Entities;
using Tic_tac_toe.Domain.Services;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddScoped<IGameService, GameService>()
            .AddScoped<IMatrixService, MatrixService>()
            .BuildServiceProvider();

            Matrix matrix1 = new(new(), new string[3, 3]);

            Game game = new("X", matrix1);

            var execute = serviceProvider.GetService<IGameService>();

            execute.StartGame(game);
        }
    }
}
