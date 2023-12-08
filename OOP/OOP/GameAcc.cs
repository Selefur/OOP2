using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class GameAccount
    {
        public string UserName { get; set; }
        public int CurrentRating { get; set; }
        public int GamesCount { get; set; }
        public List<GameResult> GameResults { get; set; } = new List<GameResult>();

        public GameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 100;
            GamesCount = 0;
        }
        public void WinGame(Game game, string player, int gameIndex)
        {
            int rating = RatingCalc(game.getPlayRating(this));
            CurrentRating += rating;
            GamesCount++;
            string winner = "виграв";
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, CurrentRating));
        }
        public void LoseGame(Game game, string player, int gameIndex)
        {
            int rating = RatingCalc(game.getPlayRating(this));
            if (CurrentRating > 1)
            {
                CurrentRating -= rating;
                if (CurrentRating < 1)
                {
                    CurrentRating = 1;
                }
            }
            GamesCount++;
            string winner = "програв";
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, CurrentRating));
        }
        public void DrawGame(Game game, string player, int gameIndex, int currentRating)
        {
            GamesCount++;
            string winner = "нічия";
            int rating = RatingCalc(game.getPlayRating(this));
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, currentRating));
        }
        public void GetStats()
        {
            foreach (GameResult result in GameResults)
            {
                Console.WriteLine($"Гра проти {result.Opponent}, {result.IsWin}, Рейтинг на який грали: {result.Rating}, Ваш рейтинг: {result.CurrentRating}, Гра #{result.GameIndex}");
            }
        }
        public virtual int RatingCalc(int rating)
        {
            return rating;
        }
    }
}
