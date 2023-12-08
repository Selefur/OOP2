using OOP.GameType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class GameFactory
    {
        public Game CreateStandartGame(GameAccount player1, GameAccount player2)
        {
            return new StandartGame(player1, player2);
        }
        public Game CreateUnrankedGame(GameAccount player1, GameAccount player2)
        {
            return new UnrankedGame(player1, player2);
        }
        public Game CreatePoint5Game(GameAccount player1, GameAccount player2)
        {
            return new Point5Game(player1, player2);
        }
    }

}
