namespace Dsv_Project_v3.Models
{
    public class IDModel
    {
        int _meetingRoomID;
        string _name;
        DateTime _timeStart;


        public int MeetingRoomID { get => _meetingRoomID; set => _meetingRoomID = value; }
        public DateTime TimeStart { get => _timeStart; set => _timeStart = value; }
        public string Name { get => _name; set => _name = value; }


        public IDModel()
        {
        }
        public IDModel(int meetingRoomID, DateTime dateTime, string name) : this()
        {
            MeetingRoomID = meetingRoomID;
            _timeStart = dateTime;
            _name = name;
        }
    }
}
