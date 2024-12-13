using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Data;
using HillerødSejlKlub;
using HilleroedSejlKlubLibrary.Models;
using HilleroedSejlKlubLibrary.Data;


namespace HillerødSejlKlubWeb.Pages
{
    public class BoatsModel : PageModel
    {
        private readonly BoatRepository _boatRepository;


        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
     
        public string BoatName { get; set; }

        [BindProperty]

        public string ImagePath { get; set; }

        [BindProperty]
        public string BoatModel { get; set; }

        [BindProperty]
        public int Size { get; set; } // Assuming size is in meters

        [BindProperty]
        public int Year { get; set; }

        [BindProperty]
        public string SailNumber { get; set; }
        [BindProperty]
        public BoatType BoatType { get; set; }

        [BindProperty]
        public Engine Engine { get; set; }



        // BindProperties for Engine Details
        [BindProperty]
        public string EngineName { get; set; }
        [BindProperty]
        public int TankCapacity { get; set; }
        [BindProperty]
        public int BatteryCapacity { get; set; }
        [BindProperty]
        public int Cylinders { get; set; }

        [BindProperty]
        public FuelType FuelType { get; set; }



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
            Boats = _boatRepository.GetAll();

            foreach (var item in Boats)
            {
                _logger.LogInformation($"Boat found: {item.Key}, {item.Value}");
            }
        }

        public IActionResult OnPost()
        {


            // Input validation logic (if needed)
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Create the new boat object
            var newBoat = new Boat
            {
                Name = BoatName,
                Model = BoatModel,
                BoatType = BoatType,
                Size = Size,
                Year = Year,
                SailNumber = SailNumber,
                ImagePath = ImagePath,
                Engine = Engine
            };


            _boatRepository.AddBoat(newBoat);

            return RedirectToPage("/Boats");

        }


    }



}

