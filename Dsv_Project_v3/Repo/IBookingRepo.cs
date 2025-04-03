using Dsv_Project_v3.Models;

namespace Dsv_Project_v3.Repo
{
    public interface IBookingRepo
    {
        void Add(MeetingRoomBooking booking);

        List<MeetingRoomBooking> GetAll();

        void Delete(int bookingId);
    }
}
