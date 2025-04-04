using Dsv_Project_v3.Repo;
using Dsv_Project_v3.Models;
using System.Diagnostics;

namespace Dsv_Project_v3.Repo
{
    public class RoomCollectionRepo : IRoomRepo
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

        public List<Room> GetAll()
        {
            return _rooms;
        }

        public List<Room> Filter(int cap, bool projecter, bool tavle, bool kaffe)
        {
            List<Room> filterRooms = new List<Room>();

            if (projecter == true && tavle == true && kaffe == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Projecter && room.Capacity >= cap && room.Tavle)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (tavle == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Tavle && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (projecter == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Projecter && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }
            else if (kaffe == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Kaffemaskine && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else
            {
                foreach (Room room in _rooms)
                {
                    if (room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }
            Debug.WriteLine("Testing the fucking filter" + projecter + tavle + kaffe + cap);
            return filterRooms;
        }
        public RoomCollectionRepo()
        {
            _rooms.Add(new Room("Alpha", 30, true, false));
            _rooms.Add(new Room("Beta", 60, true, true));
            _rooms.Add(new Room("Charlie", 20, true, false));
            _rooms.Add(new Room("Delta", 100, true, true));
            _rooms.Add(new Room("Echo", 20, false, false));
            _rooms.Add(new Room("Foxtrot", 50, false, true));
        }
    }
}
