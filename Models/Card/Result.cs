namespace PokeCardLog.Models.Card
{
    public class Result
    {
        public Data[] data { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public int count { get; set; }
        public int totalCount { get; set; }
    }
}
