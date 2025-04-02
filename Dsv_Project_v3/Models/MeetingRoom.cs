using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dsv_Project_v3.Models
{
    public class MeetingRoom
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public string Equipment { get; set; }
        public string Floor { set; get; }
        public int Nrpersons { set; get; }

        public MeetingRoom()
        {

        }
        public MeetingRoom(int ID, string name, string equipment, string floor, int nrpersons)
        {
            ID = ID;
            Name = name;
            Equipment = equipment;
            Floor = floor;
            Nrpersons = nrpersons;
        }
    }
}
