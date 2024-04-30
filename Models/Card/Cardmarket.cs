using System.Diagnostics;

namespace PokeCardLog.Models.Card
{
    public class Cardmarket
    {
        public string url { get; set; }
        public string updatedAt { get; set; }
        public Prices1? prices { get; set; }
    }
}
