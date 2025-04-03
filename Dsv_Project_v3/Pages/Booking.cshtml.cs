using Dsv_Project_v3.Models;
using Dsv_Project_v3.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Dsv_Project_v3.Services;

namespace Dsv_Project_v3.Pages
{
    public class BookingModel : PageModel
    {
        private BookingService _bookingService;
        [BindProperty]
        public MeetingRoomBooking MeetingRoomBooking { get; set; }
        public int Lokale { get; set; }

        public BookingModel(BookingService bs)
        {
            MeetingRoomBooking = new MeetingRoomBooking();
            _bookingService = bs;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("test " + MeetingRoomBooking.ID);
            _bookingService.Add(MeetingRoomBooking);
            return RedirectToPage("/BookingsEditor");
        }
    }
}
