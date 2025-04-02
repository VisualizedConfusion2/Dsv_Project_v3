using Dsv_Project_v3.Models;

namespace Dsv_Project_v3.Repo
{
    public interface IRoomRepo
    {
        public List<MeetingRoom> GetAll();
        public void Add(MeetingRoom meetingRoom);
        public MeetingRoom Get(int id);
    }
}
