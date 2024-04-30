using Microsoft.AspNetCore.Mvc;
using PokeCardLog.Models.Api;
using PokeCardLog.ViewModel;

namespace PokeCardLog.Controllers
{
    public class CardController : Controller
    {
        private readonly Api _api;
        public async Task<IActionResult> IndexAsync()
        {
            Api api = new Api({ YOUR APIKEY });
            var results = await api.GetAllCards();
            CardIndexViewModel cardIndexViewModel = new CardIndexViewModel(api, results);
            return View(cardIndexViewModel);
        }
    }
}
