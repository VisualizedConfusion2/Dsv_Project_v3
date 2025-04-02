using Dsv_Project_v3.Models;
using Dsv_Project_v3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private RoomServices _roomservices;

        public List<MeetingRoom> MeetingRooms { get; set; }

        public IndexModel(ILogger<IndexModel> logger, RoomServices roomServices)
        {
            _logger = logger;
            MeetingRooms = roomServices.GetAll();
            _roomservices = roomServices;
        }

        public void OnGet()
        {

        }
    }
}
