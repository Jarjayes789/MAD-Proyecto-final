using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class HotelModel
    {
        public int Id_Hotel { get; set; }
        public string Hotel_Name { get; set; }
        public byte Number_Floors { get; set; }
        public short Number_Rooms { get; set; }
        public DateTime Begin_Operations { get; set; }
        public int Id_User { get; set; }
        public DateTime Date_Reg { get; set; }

        //public int Id_City { get; set; }
        //public int Id_State { get; set; }
        //public int Id_Country { get; set; }
    }
}
