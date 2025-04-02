using Dsv_Project_v3.Repo;
using Dsv_Project_v3.Models;

namespace Dsv_Project_v3.Services
{
    public class RoomServices
    {
        private IRoomRepo _roomRepo; //Creates a new instance for Room repository


        public RoomServices(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;

        }

        public List<MeetingRoom> GetAll()
        {
            return _roomRepo.GetAll();
        }

        public void Add(MeetingRoom meetingRoom)
        {
            _roomRepo.Add(meetingRoom);
        }
        public MeetingRoom Get(int id)
        {
            return _roomRepo.Get(id);
        }
    }
}
