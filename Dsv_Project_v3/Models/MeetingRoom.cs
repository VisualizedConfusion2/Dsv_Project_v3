using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Models
{
    public class MeetingRoom
    {
        private static int _CountID = 1;

        public string Name { get; set; }
        public int ID { get; set; }
        public int Capacity { get; set; }
        public bool Tavle { get; set; }
        public bool Projecter { get; set; }
        public bool Kaffemaskine { get; set; }


        public MeetingRoom()
        {
            Name = "test";
            ID = _CountID++;
            Capacity = 0;
            Tavle = false;
            Projecter = false;
            Kaffemaskine = false;
        }


        // Default Contructor for a room without equipment
        public MeetingRoom(string name, int cap) : this()
        {
            Name = name;
            Capacity = cap;
        }

        // In depth Constructor with all proterties
        public MeetingRoom(string name, int cap, bool tavle, bool projecter, bool kaffemaskine): this(name, cap)
        {
            Tavle = tavle;
            Projecter = projecter;

        }
    }
}
