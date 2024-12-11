using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace HillerødSejlKlubWeb.Pages
{
    public class BoatsModel : PageModel
    {
        private readonly BoatRepository _boatRepository;

        private readonly ILogger<IndexModel> _logger;


        public Dictionary<int, Boat> Boats { get; set; }

        public BoatsModel(BoatRepository boatRepository, ILogger<IndexModel> logger)
        {
            _boatRepository = boatRepository;
            _logger = logger;
            _logger.LogInformation("This is an info log.");
            _logger.LogWarning("This is a warning log.");
            _logger.LogError("This is an error log.");

        }


        public void OnGet()
        {
            Boats = _boatRepository.GetAllBoats();

            foreach (var item in Boats)
            {
                _logger.LogInformation($"Boat found: {item.Key}, {item.Value}");
            }
        }


    }
}
