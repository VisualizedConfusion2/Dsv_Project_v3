using Dsv_Project_v3.Repo;
using Dsv_Project_v3.Models;

namespace Dsv_Project_v3.Repo
{
    public class RoomCollectionRepo:IRoomRepo
    {
        List<MeetingRoom> _meetingRoom = new List<MeetingRoom>();

        public RoomCollectionRepo()
        {
            _meetingRoom.Add(new MeetingRoom(1, "Alfa", "Tavle", 1, 2, true,"","",""));
            _meetingRoom.Add(new MeetingRoom(2, "Beta", "Tavle", 2, 2, true, "", "", ""));
            _meetingRoom.Add(new MeetingRoom(3, "Delta", "Tavle", 3, 2, true, "", "", ""));
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

        public void Update(MeetingRoom room)
        {
            throw new NotImplementedException();
        }
    }
}
