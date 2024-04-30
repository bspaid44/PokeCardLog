using Microsoft.IdentityModel.Tokens;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace PokeCardLog.Models.Card
{
    public class Data
    {
        public string id { get; set; }
        public string name { get; set; }
        public string supertype { get; set; }
        public string[] subtypes { get; set; }
        public string hp { get; set; }
        public string[] types { get; set; }
        public string evolvesFrom { get; set; }
        public Ability[] abilities { get; set; }
        public Attack[] attacks { get; set; }
        public Weakness[] weaknesses { get; set; }
        public string[] retreatCost { get; set; }
        public int convertedRetreatCost { get; set; }
        public Set set { get; set; }
        public string number { get; set; }
        public string artist { get; set; }
        public string rarity { get; set; }
        public string flavorText { get; set; }
        public int[] nationalPokedexNumbers { get; set; }
        public Legalities1 legalities { get; set; }
        public Images1 images { get; set; }
        public Tcgplayer tcgplayer { get; set; }
        public Cardmarket cardmarket { get; set; }
    }
}
