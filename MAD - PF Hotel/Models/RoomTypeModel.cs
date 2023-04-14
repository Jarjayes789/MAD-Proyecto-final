using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD___PF_Hotel.Models
{
    internal class RoomTypeModel
    {
        public int id_roomType { get; set; }
        public string roomType_name { get; set; }
        public int room_quantity { get; set; }
        public int bed_quantity { get; set; }
        public float price_night { get; set; }
        public float discount { get; set; }
        public int amount_people { get; set; }

    }
}
