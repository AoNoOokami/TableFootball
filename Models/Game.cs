using System;

namespace TableFootball.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Team Team1 { get; set; }
        public int TeamScore1 { get; set; }
        public Team Team2 { get; set; }
        public int TeamScore2 { get; set; }
    }
}
