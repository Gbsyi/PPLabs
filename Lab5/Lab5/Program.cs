using System;
using System.Collections.Generic;
using System.IO;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerFactory playerFactory = new();
            TeamFactory teamFactory = new();
            MatchFactory matchFactory = new();

            Player boris = (Player) playerFactory.Create("Boris");
            Player vitaly = (Player)playerFactory.Create("Vitaly");
            Player dmitry = (Player)playerFactory.Create("Dmitry");
            Player oleg = (Player)playerFactory.Create("Oleg");

            Team first = (Team) teamFactory.Create("First", new List<Player>() { boris, vitaly });
            Team second = (Team) teamFactory.Create("Second", new List<Player>() { oleg, dmitry });

            DateTime now = DateTime.Now;
            Match match = (Match) matchFactory.Create("Abaza", now, first, second);
            match.Result.First = 5;
            match.Result.Second = 8;

            List<Match> matches = new() { match};

            Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|","Match", "FirstTeam", "SecondTeam", "Players");
            Console.WriteLine("===============================================");
            foreach (Match matchItem in matches)
            {
                Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|", match.Location, match.FirstTeam, match.SecondTeam, match.Players[0]);
                for(int i = 1; i < match.Players.Count; i++)
                {
                    Console.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|", "","","",match.Players[i]);
                }
            }

            try
            {
                using (StreamWriter sw = new(@"export.txt", false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|", "Match", "FirstTeam", "SecondTeam", "Players");
                    sw.WriteLine("===============================================");
                    foreach (Match matchItem in matches)
                    {
                        sw.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|", match.Location, match.FirstTeam, match.SecondTeam, match.Players[0]);
                        for (int i = 1; i < match.Players.Count; i++)
                        {
                            sw.WriteLine("{0,10}|{1,10}|{2,10}|{3,10}|", "", "", "", match.Players[i]);
                        }
                    }
                    Console.WriteLine("Запись в файл выполнена");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
