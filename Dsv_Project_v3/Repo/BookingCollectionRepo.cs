using Dsv_Project_v3.Models;
namespace Dsv_Project_v3.Repo
{
    public class BookingCollectionRepo : IBookingRepo
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

        public void Delete(int bookingId)
        {
            var booking = _meetingRoomBookings.FirstOrDefault(b => b.ID == bookingId);
            if (booking != null)
            {
                _meetingRoomBookings.Remove(booking);
            }
        }

        public List<MeetingRoomBooking> GetAll()
        {
            return _meetingRoomBookings;
        }

    }
}
