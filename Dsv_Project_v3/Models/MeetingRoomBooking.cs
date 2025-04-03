namespace Dsv_Project_v3.Models
{
    public class MeetingRoomBooking
    {
        static int _tempID = 1;
        int _iD;
        int _meetingRoomID;
        DateTime _timeStart;
        DateTime _endDateTime;
        string _comment;



        public int ID { get => _iD; set => _iD = value; }
        public int RoomID { get => _meetingRoomID; set => _meetingRoomID = value; }
        public DateTime StartDateTime { get => _timeStart; set => _timeStart = value; }
        public DateTime EndDateTime { get => _endDateTime; set => _endDateTime = value; }
        public string Comment { get => _comment; set => _comment = value; }


        //def constructor
        public MeetingRoomBooking()
        {
            _iD = _tempID++;
            RoomID = 0;
            _timeStart = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
            _endDateTime = DateTime.Now.Date.AddHours(DateTime.Now.Hour).AddHours(1);
            _comment = "";
        }



        public MeetingRoomBooking(int MeetingRoomID, DateTime TimeStart, DateTime endDateTime, string comment) : this()
        {
            _meetingRoomID = MeetingRoomID;
            _timeStart = TimeStart;
            _endDateTime = endDateTime;
            _comment = comment;
        }
    }
}
