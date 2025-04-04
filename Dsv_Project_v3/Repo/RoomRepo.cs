using Dsv_Project_v3.Models;
using System.Diagnostics;
namespace Dsv_Project_v3.Repo 
{

    public class RoomRepo : IRoomRepo
    {
        List<MeetingRoom> _rooms = new List<MeetingRoom>();

        public void Add(MeetingRoom room)
        {
            _rooms.Add(room);
        }

        public MeetingRoom Get(int id)
        {
            foreach (MeetingRoom room in _rooms)
            {
                if (id == room.ID)
                {
                    return room;
                }
            }
            return null;
        }

        public List<MeetingRoom> GetAll()
        {
            return _rooms;
        }

        public List<MeetingRoom> Filter(int cap, bool projecter, bool tavle, bool kaffe)
        {
            List<MeetingRoom> filterRooms = new List<MeetingRoom>();

            if (projecter == true && tavle == true && kaffe == true)
            {
                foreach (MeetingRoom room in _rooms)
                {
                    if (room.Projecter && room.Capacity >= cap && room.Tavle)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (tavle == true)
            {
                foreach (MeetingRoom room in _rooms)
                {
                    if (room.Tavle && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (projecter == true)
            {
                foreach (MeetingRoom room in _rooms)
                {
                    if (room.Projecter && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }
            else if (kaffe == true)
            {
                foreach (MeetingRoom room in _rooms)
                {
                    if (room.Kaffemaskine && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else
            {
                foreach (MeetingRoom room in _rooms)
                {
                    if (room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }
            Debug.WriteLine("" + projecter + tavle + kaffe + cap);
            return filterRooms;
        }


        public RoomRepo()
        {
            _rooms.Add(new MeetingRoom("Alpha", 30, false, true, false));
            _rooms.Add(new MeetingRoom("Beta", 60, true, true, true));
            _rooms.Add(new MeetingRoom("Delta", 20, false, false, false));
            _rooms.Add(new MeetingRoom("Gamma", 100, true, true, true));
            _rooms.Add(new MeetingRoom("Sigma", 20, true, true, false));
            _rooms.Add(new MeetingRoom("Mu", 50, true, true, true));
        }
    }
}
