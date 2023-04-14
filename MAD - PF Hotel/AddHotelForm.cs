using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD___PF_Hotel
{
    public partial class AddHotelForm : Form
    {
        Conexion sqlConexion = new Conexion();
        public AddHotelForm()
        {
            InitializeComponent();
        }

        private void HODForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            HotelModel new_hotel = new HotelModel();
            AddressModel new_address = new AddressModel();

            new_hotel.Hotel_Name = txtboxHotelName.Text;
            new_hotel.Number_Floors = byte.Parse(txtboxNumberOfFloors.Text);
            new_hotel.Number_Rooms = short.Parse(txtboxNumberOfRooms.Text);
            new_hotel.Begin_Operations = dtpBeginOperations.Value;

            new_address.Street_Name = txtboxHotelStreet.Text;
            new_address.House_Number = txtboxHotelNumber.Text;
            new_address.Suburb_Name = txtboxHotelSuburb.Text;
            new_address.Zip_Code = txtboxHotelZipCode.Text;


            bool resultHotel = sqlConexion.AddHotel(new_hotel, new_address);

            if (resultHotel)
            {
                this.Hide();
                MessageBox.Show("The operator fue agregado a la base de datos.");
            }
            else
            {
                MessageBox.Show("The email or password are invalid");
            }
        }
    }
}
