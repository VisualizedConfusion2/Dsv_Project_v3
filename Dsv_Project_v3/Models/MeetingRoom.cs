using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Models
{
    public class MeetingRoom
    {
        private static int _tempID = 1; // instance

        public string Name { get; set; }
        public int ID { get; set; }
        public int Capacity { get; set; }
        public bool Whiteboard { get; set; }
        public bool SmartBoard { get; set; }


        public MeetingRoom()
        {
            Name = "test";
            ID = _tempID++;
            Capacity = 0;
            Whiteboard = false;
            SmartBoard = false;
        }


        // Default Contructor for a room without equipment
        public MeetingRoom(string name, int cap) : this()
        {
            Name = name;
            Capacity = cap;
        }

        // In depth Constructor with all proterties
        public MeetingRoom(string name, int cap, bool whiteboard, bool smartboard) : this(name, cap)
        {
            Whiteboard = whiteboard;
            SmartBoard = smartboard;
        }
    }
}
