﻿using Dsv_Project_v3.Repo;
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

        public List<Room> Filter(int cap, bool whiteb, bool smartb)
        {
            List<Room> filterRooms = new List<Room>();

            if (smartb == true && whiteb == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.SmartBoard && room.Capacity >= cap && room.Whiteboard)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (whiteb == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.Whiteboard && room.Capacity >= cap)
                    {
                        filterRooms.Add(room);
                    }
                }
            }

            else if (smartb == true)
            {
                foreach (Room room in _rooms)
                {
                    if (room.SmartBoard && room.Capacity >= cap)
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
            Debug.WriteLine("Testing the fucking filter" + whiteb + smartb + cap);
            return filterRooms;
        }

        //room objects for testing purposes
        public RoomCollectionRepository()
        {
            _rooms.Add(new Room("Alpha", 30, true, false, "conference1.jpg"));
            _rooms.Add(new Room("Beta", 60, true, true, "conference2.jpg"));
            _rooms.Add(new Room("Charlie", 20, true, false, "conference3.jpg"));
            _rooms.Add(new Room("Delta", 100, true, true, "conference4.jpg"));
            _rooms.Add(new Room("Echo", 20, false, false, "conference3.jpg"));
            _rooms.Add(new Room("Foxtrot", 50, false, true, "conference1.jpg"));
        }
    }
}
