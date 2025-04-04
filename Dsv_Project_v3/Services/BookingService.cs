using System.Diagnostics;
using Dsv_Project_v3.Models;
using Dsv_Project_v3.Repo;

namespace Dsv_Project_v3.Services
{
    public class BookingService
    {
        private readonly IBookingRepo _bookingRepo;

        // Konstruktør der injicerer IBookingRepo
        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo ?? throw new ArgumentNullException(nameof(bookingRepo));
        }

        public List<MeetingRoomBooking> GetAll()
        {
            return _bookingRepo.GetAll();
        }

        public void Add(MeetingRoomBooking book)
        {
            _bookingRepo.Add(book);
        }

        public void DeleteBooking(int bookingId)
        {
            _bookingRepo.Delete(bookingId);
        }

        public void UpdateBooking(MeetingRoomBooking updatedBooking)
        {
            var existingBooking = _bookingRepo.GetAll().FirstOrDefault(b => b.ID == updatedBooking.ID);
            Debug.WriteLine(updatedBooking.ID);
            if (existingBooking != null)
            {
                existingBooking.StartDateTime = updatedBooking.StartDateTime;
                existingBooking.EndDateTime = updatedBooking.EndDateTime;
                existingBooking.Comment = updatedBooking.Comment;
            }
        }
    }
}

