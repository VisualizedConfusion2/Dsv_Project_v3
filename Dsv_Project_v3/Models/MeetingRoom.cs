using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Models
{
    public class MeetingRoom
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public string Equipment { get; set; }
        public int Floor { set; get; }
        public int Nrpersons { set; get; }
        public bool IsAvailable { get; set; }

        public MeetingRoom()
        {

        }
        public MeetingRoom(int iD, string name, string equipment, int floor, int nrpersons, bool isAvailable)
        {
            ID = iD;
            Name = name;
            Equipment = equipment;
            Floor = floor;
            Nrpersons = nrpersons;
            IsAvailable = isAvailable;
        }
    }
}
