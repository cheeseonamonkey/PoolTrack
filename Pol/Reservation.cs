using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol
{
    public class Reservation
    {
        public DateTime ResTime
        {
            get; set;
        }
        public int Room
        {
            get;set;
        }
        public string Guest
        {
            get;set;
        }
        public string Employee
        {
            get;set;
        }
        public string Comments
        {
            get; set;
        }

        public Reservation(DateTime dateTime, int room, string guest, string employee)
        {
            ResTime = dateTime;
            Room = room;
            Guest = guest;
            Employee = employee;
            Comments = "";
        }

        public string GetTag() => $"{Room}{Guest}{ResTime}";
    }
}
