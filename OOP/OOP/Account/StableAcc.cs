using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Account
{
    class StableRatingAccount : GameAccount
    {
        public StableRatingAccount(string userName) : base(userName)
        {

        }
        public override int RatingCalc(int rating)
        {
            return 0;
        }
    }
}
