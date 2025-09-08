using betrayal_hill.Data;
using Microsoft.AspNetCore.Mvc;

namespace betrayal_hill.Controllers
{
    // Temporary test controller
    public class TestController(BetrayalContext context) : Controller
    {
        private readonly BetrayalContext _context = context;

        public IActionResult Explorers()
        {
            var characters = _context.Explorers.ToList();
            return Json(characters);
        }

        public IActionResult Cards()
        {
            var cards = _context.Cards.ToList();
            return Json(cards);
        }
    }
}
