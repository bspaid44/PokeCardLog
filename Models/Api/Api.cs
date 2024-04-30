using Newtonsoft.Json;
using PokeCardLog.Models.Card;

namespace PokeCardLog.Models.Api
{
    public class Api : HttpClient
    {
        string apikey { get; set; }
        public Api(string apikey)
        {
            this.apikey = apikey;
        }

        public async Task<Result> GetAllCards()
        {
            string url = "https://api.pokemontcg.io/v2/cards";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Api-Key", apikey);

            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var cards = JsonConvert.DeserializeObject<Result>(content);
            return cards;

        }

        public async Task<Result> GetCard(string cardName)
        {
            string url = $"https://api.pokemontcg.io/v2/cards?q=name:{cardName}";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Api-Key", apikey);

            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var cards = JsonConvert.DeserializeObject<Result>(content);

            return cards;
        }
    }
}
