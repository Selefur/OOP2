using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Account
{
    class StandartAccount : GameAccount
    {
        public StandartAccount(string userName) : base(userName)
        {

        }
        public override int RatingCalc(int rating)
        {
            return rating;
        }
    }
}
