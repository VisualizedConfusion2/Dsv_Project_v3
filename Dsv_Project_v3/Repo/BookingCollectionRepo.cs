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
            throw new NotImplementedException();
        }

        public List<MeetingRoomBooking> GetAll()
        {
            return _meetingRoomBookings;
        }

    }
}
