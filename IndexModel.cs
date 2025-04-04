using Dsv_Project_v3.Models;
using Dsv_Project_v3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RoomServices _rs;
        private readonly BookingService _bs;
        [BindProperty]
        public List<MeetingRoom> Rooms { get; set; }

        public List<MeetingRoomBooking> Bookings { get; set; }
        List<MeetingRoomBooking> _activeBookings = new List<MeetingRoomBooking>();

        bool _isBooked = false;
        [BindProperty]
        public int filterCap { get; set; }
        [BindProperty]
        public bool filterTavle { get; set; }
        [BindProperty]
        public bool filterProjecter { get; set; }
        [BindProperty]
        public bool filterKM { get; set; }

        private DateTime setDate = DateTime.Now;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, RoomServices rs, BookingService bs)
        {
            _logger = logger;
            Rooms = rs.GetAll();
            _rs = rs;
            Bookings = bs.GetAll();
            _bs = bs;
        }

        public void Vacancy()
        {
            foreach (MeetingRoomBooking booking in Bookings)
            {
                if (booking.StartDateTime.Date == setDate.Date)
                {
                    _activeBookings.Add(booking);
                }
            }
        }

        public bool BookChecker(int hour, int roomID)
        {
            if (_activeBookings != null)
            {
                foreach (var booking in _activeBookings)
                {
                    if (hour == booking.StartDateTime.Hour && roomID == booking.RoomID)
                    {
                        _isBooked = true;
                    }
                    else if (hour == booking.EndDateTime.Hour && roomID == booking.RoomID)
                    {
                        _isBooked = false;
                    }
                }
            }
            return _isBooked;
        }

        public void OnGet()
        {
            Vacancy();
        }

        public IActionResult OnPost(int idroom)
        {
            MeetingRoom bound = _rs.Get(idroom);

            return RedirectToPage("/Booking", new { roomname = bound.ID });
        }
    }
}
