using System;
using System.Collections.Generic;

namespace AssignmentThreeAndFour
{
    internal class HotelManSys
    {
        private string[] staff = { "Abongile", "Theo" };
        DateTime checkintime =new DateTime();
        DateTime checkoutTime = new DateTime();
        private int period;
        private string guest;
        private Dictionary<string, bool> rooms = new Dictionary<string, bool>
        {
            {"FIL0", true}, {"FIL1", true}, {"FIL2", true}, {"FIL3",true}
        };

        public HotelManSys()
        {

        }
        public HotelManSys(string[] staff, DateTime checkinTime)
        {
            this.staff = staff;
            
        }

        public string BookRoom(int roomNumber,int id)
        {
            string roomKey = $"FIL{roomNumber}";

  
            

            if (rooms.ContainsKey(roomKey) ) 
            {
                if (rooms[roomKey]) 
                {
                    rooms[roomKey] = false; 
                    checkintime = (DateTime.Now).ToLocalTime();
                    return $"Room {roomKey} successfully booked! by {(staff[id])} at {checkintime.}";
                }
                else
                {
                    return $"Room {roomKey} is already booked.";
                }
            }
            else
            {
                return "Invalid room number.";
            }
        }

        
        public string CheckoutRoom(int roomNumber)
        {
            string roomKey = $"FIL{roomNumber}"; 

            if (rooms.ContainsKey(roomKey)) 
            {
                if (!rooms[roomKey]) 
                {
                    rooms[roomKey] = true;
                    checkoutTime = (DateTime.Now).ToLocalTime();

                    return $"Room {roomKey} successfully checked out! at {checkoutTime}";
                }
                else
                {
                    return $"Room {roomKey} is already available.";
                }
            }
            else
            {
                return "Invalid room number.";
            }
        }

        //methods to check the availability of rooms, etc.
        public void PrintRoomStatus()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room {room.Key}: {(room.Value ? "Available" : "Booked")}");
            }
        }
    }


}
