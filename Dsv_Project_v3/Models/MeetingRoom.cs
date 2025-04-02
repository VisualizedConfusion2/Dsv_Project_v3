using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Models
{
    public class MeetingRoom
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public int Nrpersons { get; set; }
        public string Equipment { get; set; }
        public int Floor { get; set; }
        public bool IsAvailable { get; set; } = true;
        public string BookingDate { get; set; }
        public string BookingStartTime { get; set; }
        public string BookingEndTime { get; set; }
        public string Comment { get; set; }

        public MeetingRoom()
        {

        }
        public MeetingRoom(int iD, string name, string equipment, int floor, int nrpersons, bool isAvailable, string bookingDate, string bookingStartTime, string bookingEndTime)
        {
            ID = iD;
            Name = name;
            Equipment = equipment;
            Floor = floor;
            Nrpersons = nrpersons;
            IsAvailable = isAvailable;
            BookingDate = bookingDate;
            BookingStartTime = bookingStartTime;
            BookingEndTime = bookingEndTime;
        }
    }
}
