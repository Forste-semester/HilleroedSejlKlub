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


        public Dictionary<int, Boat> Boats { get; set; }

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

       
         public Engine Engine { get; set; }



        // ------- BindProperties for Engine Details
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

       
        public BoatsModel(BoatRepository boatRepository, ILogger<IndexModel> logger)
        {

            
            _boatRepository = boatRepository;
            _logger = logger;
            _logger.LogInformation("This is an info log.");
            _logger.LogWarning("This is a warning log.");
            _logger.LogError("This is an error log.");
            Boats = _boatRepository.GetAll();

        }



        public void OnGet()
        {
           

            foreach (var item in Boats)
            {
                _logger.LogInformation($"Boat found: {item.Key}, {item.Value}");
            }
        }

        public IActionResult OnPostDeleteBoat(int id)
        {
            if (id == null)  {           
                ModelState.AddModelError(string.Empty, "Boat not found.");
                return RedirectToPage();  // Reload the page
            }

            try
            {
                _boatRepository.RemoveBoatByID(id);
            }
            catch (ArgumentException)
            {
                // Handle the case where the event doesn't exist
                ModelState.AddModelError(string.Empty, "Boat not found.");
            }

            // Reload the event list after deletion
            return RedirectToPage();  // This refreshes the page

        }

        public IActionResult OnPost()
        {
            

            switch(FuelType)
            {
                case FuelType.El:
                    Engine = new ElectricEngine(EngineName, BatteryCapacity, FuelType);
                    break;
                case FuelType.Benzin:
                    Engine = new GasEngine(EngineName, TankCapacity, Cylinders, FuelType);
                    break;
                case FuelType.Diesel:
                    Engine = new DieselEngine(EngineName, TankCapacity, FuelType);
                    break;


            }

       
            var newBoat = new Boat
            {
                Name = BoatName,
                Model = BoatModel,
                BoatType = BoatType,
                Size = Size,
                Year = Year,
                SailNumber = SailNumber,
                ImagePath = "/images/billede-paa-vej.jpg",
                Engine = Engine
            };


            _boatRepository.AddBoat(newBoat);

            return RedirectToPage("/Boats");

        }


    }



}

