using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Collections.Generic;
using HillerødSejlKlub.Interfaces;
using System.Runtime.Serialization;

namespace HillerødSejlKlubWeb.Pages
{
    public class EventModel : PageModel
    {
        private readonly EventRepository _eventRepository;
        private readonly UserRepository _userRepository;

        [BindProperty]
        public List<Event> Events { get; set; }

        [BindProperty]
        public List<User> Users { get; set; }  // List of users to choose from

        [BindProperty(SupportsGet = true)]
        public string SelectedEventTitle { get; set; }  // The selected event's title

        public string ErrorMessage { get; set; }

        
        public List<User> Participants { get; set; }

        public EventModel(EventRepository eventRepository, UserRepository userRepository)
        {
            _eventRepository = eventRepository;
            _userRepository = userRepository;
        }

        // OnGet method fetches both Events and Users
        public void OnGet()
        {
            try
            {
                Events = _eventRepository.GetAllEvents();  // Fetch all events from the repository
                Users = _userRepository.GetAllUsers().Values.ToList();  // Fetch all users from the UserRepository
            }
            catch (ArgumentException ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        // OnPostDeleteEvent handles the event deletion
        public IActionResult OnPostDeleteEvent(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                ModelState.AddModelError(string.Empty, "Event title is required.");
                TempData["ErrorMessage"] = "Event title is required."; // Set error message
                return RedirectToPage();  // Reload the page
            }

            try
            {
                _eventRepository.RemoveEvent(title);
                TempData["SuccessMessage"] = "Event deleted successfully.";  // Set success message
            }
            catch (ArgumentException)
            {
                // Handle the case where the event doesn't exist
                TempData["ErrorMessage"] = "Event not found.";  // Set error message
            }

            // Reload the event list after deletion
            return RedirectToPage();  // This refreshes the page
        }

        // OnPostJoinEvent handles the logic for joining an event
        public IActionResult OnPostJoinEvent(int userId)
        {
            var selectedUser = _userRepository.GetUserById(userId); // Fetch user by ID
            var eventToJoin = _eventRepository.GetEventByTitle(SelectedEventTitle);

            if (selectedUser != null && eventToJoin != null)
            {
                try
                {
                    _eventRepository.JoinEvent(SelectedEventTitle, selectedUser);
                    TempData["SuccessMessage"] = $"User {selectedUser.Name} has successfully joined the event {eventToJoin.Title}.";
                    TempData["EventTitle"] = eventToJoin.Title;  // Store event title to show message for the correct event
                    TempData["ShowUsers"] = true;  // Set flag to show users after joining event
                }
                catch (ArgumentException ex)
                {
                    TempData["ErrorMessage"] = ex.Message;  // Show error if user can't join
                    TempData["EventTitle"] = SelectedEventTitle;  // Store event title to show message for the correct event
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Invalid user or event.";
                TempData["EventTitle"] = SelectedEventTitle;  // Store event title to show message for the correct event
            }

            // Redirect to the events page to refresh the list
            return RedirectToPage();
        }


    }
}
