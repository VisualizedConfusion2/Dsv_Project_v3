using Dsv_Project_v3.Repo;
using Dsv_Project_v3.Models;

namespace Dsv_Project_v3.Repo
{
    public class RoomCollectionRepo:IRoomRepo
    {
        List<MeetingRoom> _meetingRoom = new List<MeetingRoom>();

        public RoomCollectionRepo()
        {
            _meetingRoom.Add(new MeetingRoom(1, "Buster", "Verdens sødeste kat", "flatten.jpg", 2));
            _meetingRoom.Add(new MeetingRoom(2, "Simba", "En stor mis", "Simba21-1024x683.jpg", 2));
            _meetingRoom.Add(new MeetingRoom(3, "Adolf", "En tysk kat", "tyskkat.jpg", 2));
        }
        public List<MeetingRoom> GetAll()
        {
            return _meetingRoom;
        }
        public void Add(MeetingRoom meetingRoom)
        {
            _meetingRoom.Add(meetingRoom);
        }

        public MeetingRoom Get(int id)
        {
            foreach (MeetingRoom meetingRoom in _meetingRoom)
            {
                if (meetingRoom.ID == id)
                {
                    return meetingRoom;
                }
            }
            return null;
        }
    }
}
