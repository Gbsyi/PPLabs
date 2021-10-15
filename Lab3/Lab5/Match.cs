using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Match
    {
        DateTime Date;
        string Location;
        (int FirstTeam, int SecondTeam) result;
        Team FirstTeam;
        Team SecondTeam;
        List<Player> Players;
        
        public Match(DateTime date, string location, Team firstTeam, Team secondTeam)
        {
            Date = date;
            Location = location;
            FirstTeam = firstTeam;
            SecondTeam = secondTeam;
        }
        
        public void setScore(int firstTeamResult, int secondTeamResult)
        {
            result.FirstTeam = firstTeamResult;
            result.SecondTeam = secondTeamResult;
        }
    }
}
