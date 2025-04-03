using System.Diagnostics;
using Dsv_Project_v3.Models;
using Dsv_Project_v3.Repo;

namespace Dsv_Project_v3.Services
{
    public class BookingService
    {
        private IBookingRepo _bookingRepo;

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

        //Method to update the booking list
        public void UpdateBooking(MeetingRoomBooking updatedBooking)
        {
            // Find the existing booking by ID
            var existingBooking = _bookingRepo.GetAll().FirstOrDefault(b => b.ID == updatedBooking.ID);
            Debug.WriteLine(updatedBooking.ID);
            if (existingBooking != null)
            {
                // Replace the old booking's values with the new ones
                existingBooking.StartDateTime = updatedBooking.StartDateTime;
                existingBooking.EndDateTime = updatedBooking.EndDateTime;
                existingBooking.Comment = updatedBooking.Comment;

                // In a real scenario, you might save changes to a database here
            }
        }
    }
}

