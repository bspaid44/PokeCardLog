using System.Diagnostics;

namespace PokeCardLog.Models.Card
{
    public class Tcgplayer
    {
        public string url { get; set; }
        public string updatedAt { get; set; }
        public Prices? prices { get; set; }
    }
}
