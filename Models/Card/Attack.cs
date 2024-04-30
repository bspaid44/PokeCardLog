namespace PokeCardLog.Models.Card
{
    public class Attack
    {
        public string name { get; set; }
        public string[] cost { get; set; }
        public int convertedEnergyCost { get; set; }
        public string damage { get; set; }
        public string text { get; set; }
    }
}
