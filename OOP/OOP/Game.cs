﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Game
    {
        public GameAccount player1 { get; set; }
        public GameAccount player2 { get; set; }
        public int playRating { get; set; } = 0;
        public string winner { get; set; }
        public Game(GameAccount player1, GameAccount player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public virtual int getPlayRating(GameAccount player) { return playRating; }
        public void PlayGame(GameAccount Gamer1, GameAccount Gamer2)
        {
            Console.WriteLine("На який рейтинг буде гра?: ");
            playRating = int.Parse(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("\nВведіть число від 1 до 3\n1.Камінь\n2.Ножиці\n3.Папір \n");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nГравець {Gamer1.UserName} обрав: " + a);
            int b = random.Next(1, 4);
            Console.WriteLine($"\nГравець {Gamer2.UserName} обрав: " + b);
            int gameIndex = Gamer1.GamesCount;
            if ((a == 1 && b == 2) || (a == 2 && b == 3) || (a == 3 && b == 1))
            {
                Console.WriteLine($"\nГравець {Gamer1.UserName} виграв");
                Gamer1.WinGame(this, Gamer2.UserName, gameIndex);
                Console.WriteLine($"\nГравець {Gamer2.UserName} програв");
                Gamer2.LoseGame(this, Gamer1.UserName, gameIndex);
            }
            else if ((a == 1 && b == 3) || (a == 2 && b == 1) || (a == 3 && b == 2))
            {
                Console.WriteLine($"\nГравець {Gamer2.UserName} виграв");
                Gamer2.WinGame(this, Gamer1.UserName, gameIndex);
                Console.WriteLine($"\nГравець {Gamer1.UserName} програв");
                Gamer1.LoseGame(this, Gamer2.UserName, gameIndex);
            }
            else
            {
                Console.WriteLine("\nНічия");
                Gamer1.DrawGame(this, Gamer2.UserName, gameIndex, Gamer1.CurrentRating);
                Gamer2.DrawGame(this, Gamer1.UserName, gameIndex, Gamer2.CurrentRating);
            }
        }
    }
    
}
