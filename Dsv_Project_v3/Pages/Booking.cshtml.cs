using Dsv_Project_v3.Models;
using Dsv_Project_v3.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Dsv_Project_v3.Pages
{
    public class BookingModel : PageModel
    {
        private readonly IRoomRepo _roomRepo;

        private readonly ILogger<BookingModel> _logger;
        public BookingModel(ILogger<BookingModel> logger, IRoomRepo roomRepo)
        {
            _logger = logger;
            _roomRepo = roomRepo;
        }

        [BindProperty(SupportsGet = true)]
        public string RoomName { get; set; }

        [BindProperty]
        public string MeetingDate { get; set; }

        [BindProperty]
        public string MeetingTime { get; set; }

        [BindProperty]
        public string EndMeetingTime { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public MeetingRoom SelectedRoom { get; set; }

        [BindProperty]
        public MeetingRoom meetingRoom { get; set; } = new();

        public void OnGet()
        {
            //SelectedRoom = _roomRepo.GetAll().FirstOrDefault(r => r.Name == RoomName);
            SelectedRoom = null;
            foreach (var room in _roomRepo.GetAll())
            {
                if (room.Name == RoomName)
                {
                    SelectedRoom = room;
                    break;
                }
            }
        }

        public IActionResult OnPost()
        {
            Debug.WriteLine("Booking Room: " + meetingRoom.Name);
            _roomRepo.Add(meetingRoom);
            return RedirectToPage("/Index");
        }
    }
}
