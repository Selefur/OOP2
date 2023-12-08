using OOP.Account;
using System;
using System.Collections.Generic;
namespace OOP
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Program program = new Program();
            program.Run();
        }
        public void Run()
        {
            Console.WriteLine("Введіть ім'я 1 гравця: ");
            string firstUser = Console.ReadLine();
            GameAccount player1 = AccountChose(firstUser);
            Console.WriteLine("Введіть ім'я 2 гравця: ");
            string secondUser = Console.ReadLine();
            GameAccount player2 = AccountChose(secondUser);

            int i;
            Game game = GameType(player1, player2);
            for (i = 0; i < 3; i++)
            {
                game.PlayGame(player1, player2);
            }
            player1.GetStats();
        }
        private static GameAccount AccountChose(string userName)
        {
            Console.WriteLine("Оберіть тип акаунту: \n1.StandartAccount \n2.StableRatingAccount \n3.PowerAccount");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    return new StandartAccount(userName);
                case 2:
                    return new StableRatingAccount(userName);
                case 3:
                    return new PowerAccount(userName);
                default:
                    Console.WriteLine("Невірно. Оберіть з 1-3");
                    return AccountChose(userName);
            }
        }
        private static Game GameType(GameAccount player1, GameAccount player2)
        {
            Console.WriteLine("Оберіть тип гри: \n1.StandartGame \n2.UnrankedGame \n3.Point5Game");
            int choose = int.Parse(Console.ReadLine());
            GameFactory factory = new GameFactory();
            switch (choose)
            {
                case 1:
                    return factory.CreateStandartGame(player1, player2);
                case 2:
                    return factory.CreateUnrankedGame(player1, player2);
                case 3:
                    return factory.CreatePoint5Game(player1, player2);
                default:
                    Console.WriteLine("Невірно. Оберіть 1,2 або 3.");
                    return GameType(player1, player2);
            }
        }
    }


}

