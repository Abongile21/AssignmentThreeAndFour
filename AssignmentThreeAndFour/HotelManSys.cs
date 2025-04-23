using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThreeAndFour
{
    internal class HotelManSys
    {
        private string[] staff = { "Abongile", "Theo" };
        private DateTime checkintime;
        private string checkoutime;
        private int period;
        private string guest;
        private Dictionary<string, bool> rooms = new Dictionary<string, bool>
        {
            {"FIL0",true},{"FIL1",true},{"FIL2",true}
        };



        public HotelManSys( Dictionary<bool, string> rooms, string[] staff, DateTime checkintime)
        {
            this.staff = staff;
            this.checkintime = DateTime.Now;
        }

        public string BookRoom(int room)
        {

            for (int i = 0; i < rooms.Count; i++)
            {
                if (rooms.TryGetValue($"FIL{i}", out true))
                {

                }
            }

        }







    }
}
