using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
namespace HillerødSejlKlubWeb.Pages;

public class AddEventModel : PageModel
{
    private readonly EventRepository _eventRepository;

    [BindProperty]
    public Event NewEvent { get; set; }

    public string ErrorMessage { get; set; }

    public AddEventModel(EventRepository eventRepository)
    {
        _eventRepository = eventRepository;
        NewEvent = new Event();
    }

    public IActionResult OnPost()
    {
        Console.WriteLine("Stop1");

        if (!ModelState.IsValid)
        {
            Console.WriteLine("ModelState is invalid. Errors:");
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }
        
        if (ModelState.IsValid)
        {
            Console.WriteLine("Stop2");
            // Validate time manually if not set
            if (string.IsNullOrEmpty(NewEvent.Time))
            {
                Console.WriteLine("Stop3");
                NewEvent.Time = "12:00";  // Default time if not provided
            }

            

            // Add the new event to the repository
            _eventRepository.AddEvent(
                NewEvent.Title,
                NewEvent.Body,
                NewEvent.Day,
                NewEvent.Month,
                NewEvent.Year,
                NewEvent.Time,
                NewEvent.Location,
                NewEvent.Creator,
                NewEvent.Price
            );
            Console.WriteLine("Stop4");
            return RedirectToPage("/Event");
        }

        return Page();
    }
}
