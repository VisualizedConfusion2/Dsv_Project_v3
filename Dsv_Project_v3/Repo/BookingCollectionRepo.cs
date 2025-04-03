using Dsv_Project_v3.Models;
namespace Dsv_Project_v3.Repo
{
    public class BookingCollectionRepo
    {
        private List<MeetingRoomBooking> _meetingRoomBookings;

        public BookingCollectionRepo()
        {
            _meetingRoomBookings = new List<MeetingRoomBooking>();
        }

        public void Add(MeetingRoomBooking booking)
        {
            _meetingRoomBookings.Add(booking);
        }

        public List<MeetingRoomBooking> GetAll()
        {
            return _meetingRoomBookings;
        }

    }
}
