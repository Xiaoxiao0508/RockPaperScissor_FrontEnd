using System;
using System.Collections.Generic;

namespace WebAPI.model
{
    public class Leaderboard
    {
       

        public List<Leaderboardline>  LeaderboardList { get; set; }


         public Leaderboard()
        {
        }

        public Leaderboard(List<Leaderboardline> leaderboardList)
        {
            LeaderboardList = leaderboardList;
        }
    }
}
