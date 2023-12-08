using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class GameResult
    {
        public string Opponent { get; }
        public string IsWin { get; }
        public int Rating { get; }
        public int GameIndex { get; }
        public int CurrentRating { get; }

        public GameResult(string opponent, string isWin, int rating, int gameIndex, int currentRating)
        {
            Opponent = opponent;
            IsWin = isWin;
            Rating = rating;
            GameIndex = gameIndex;
            CurrentRating = currentRating;
        }
    }
}
