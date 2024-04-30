using PokeCardLog.Models.Api;
using PokeCardLog.Models.Card;

namespace PokeCardLog.ViewModel
{
    public class CardIndexViewModel
    {
        private Api Api { get; set; }

        public Result results { get; set; }

        public CardIndexViewModel(Api api, Result result)
        {
            Api = api;
            results = result;
        }
    }
}
