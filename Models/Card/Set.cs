using static System.Net.Mime.MediaTypeNames;

namespace PokeCardLog.Models.Card
{
    public class Set
    {
        public string id { get; set; }
        public string name { get; set; }
        public string series { get; set; }
        public int printedTotal { get; set; }
        public int total { get; set; }
        public Legalities legalities { get; set; }
        public string ptcgoCode { get; set; }
        public string releaseDate { get; set; }
        public string updatedAt { get; set; }
        public Images images { get; set; }
    }
}
