using Dsv_Project_v3.Models;
using Dsv_Project_v3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dsv_Project_v3.Pages
{
    public class BookingsEditorModel : PageModel
    {
        private readonly RoomServices _rs;
        private readonly BookingService _bs;
        [BindProperty]
        public List<MeetingRoom> Rooms { get; set; }
        public List<MeetingRoomBooking> Bookings { get; set; }

        public BookingsEditorModel(BookingService bs, RoomServices rs)
        {
            Bookings = bs.GetAll();
            Rooms = rs.GetAll();
            _bs = bs;
            _rs = rs;
        }
        public void OnGet()
        {
        }

        //method for deleting bookings
        public IActionResult OnPostDeleteBooking(int bookingId)
        {
            // Call the service to delete the booking
            _bs.DeleteBooking(bookingId);

            // Redirect back to the page to refresh the list of bookings
            return RedirectToPage();
        }

        //method for editing bookings
        public IActionResult OnPostEditBooking(int bookingId, DateTime startDateTime, DateTime endDateTime, string comment)
        {
            // Find the booking by ID
            Debug.WriteLine(bookingId);
            var bookingToUpdate = Bookings.FirstOrDefault(b => b.ID == bookingId);

            if (bookingToUpdate != null)
            {
                // Replace the old booking with the updated one
                bookingToUpdate.StartDateTime = startDateTime;
                bookingToUpdate.EndDateTime = endDateTime;
                bookingToUpdate.Comment = comment;
            }

            // Save changes to the repository or perform other necessary actions
            _bs.UpdateBooking(bookingToUpdate);

            // Redirect back to the page to refresh the list
            return RedirectToPage();
        }
    }
}
