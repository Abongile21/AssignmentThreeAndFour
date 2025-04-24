using System;
using System.Collections.Generic;

namespace AssignmentThreeAndFour
{
    internal class HotelManSys
    {
        private string[] staff = { "Abongile", "Theo", "Me" };
        DateTime checkintime =new DateTime();
        DateTime checkoutTime = new DateTime();
        private string path = "C:\\Users\\Abongile_Theo\\LearnNet\\AssignmentThreeAndFour\\AssignmentThreeAndFour\\hotel.txt";
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

        public string BookRoom(int roomNumber,int id, string guest)
        {
            string roomKey = $"FIL{roomNumber}";

  
            

            if (rooms.ContainsKey(roomKey) ) 
            {
                if (rooms[roomKey]) 
                {
                    rooms[roomKey] = false; 
                    checkintime = (DateTime.Now).ToLocalTime();
                    return $"{roomKey} successfully booked! by {guest} through {(staff[id])} at {checkintime}";
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

                    return $" Guest at Room-{roomKey} successfully checked out! at {checkoutTime}\n"+
                        "Thank for staying with us!!"; ;
                    
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

        public void PrintRoomStatus()
        {

            Console.WriteLine("-------------------Room statuses-----------------");
            foreach (var room in rooms)
            {

                
                Console.WriteLine($"Room {room.Key}: {(room.Value ? "Available" : "Booked")}");
            }
        }

        public void writetoFile()
        {
            
           
            using (StreamWriter writetext = new StreamWriter(path, append: true))

            {   
                writetext.WriteLine($"-------------------Room statuses----------------- at {(DateTime.Now).ToLocalTime()} ----");
                foreach (var room in rooms)
                {
                    writetext.WriteLine($"Room {room.Key}: {(room.Value ? "Available" : "Booked")} ");
                }
               
            }
        }
        
    }


}
