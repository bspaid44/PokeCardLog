using Microsoft.SqlServer.Server;

namespace PokeCardLog.Models.Card
{
    public class Prices
    {
        public Normal normal { get; set; }
        public Reverseholofoil? reverseHolofoil { get; set; }
    }
}
