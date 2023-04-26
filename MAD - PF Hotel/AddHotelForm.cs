using MAD___PF_Hotel.ConexionDB;
using MAD___PF_Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            cBoxCountry.DataSource = FillCountriesBox();
            cBoxCountry.DisplayMember = "COUNTRY_NAME";
            cBoxCountry.ValueMember = "ID_COUNTRY";
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

            if (HotelValidation(new_hotel) || AddressValidation(new_address))
            {
                MessageBox.Show("Please, fill all the text box from the form.");
            }
            else
            {
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

        private bool HotelValidation(HotelModel aux_model)
        {
            if (aux_model.Hotel_Name == null || aux_model.Number_Floors == 0 || aux_model.Number_Rooms == 0 || aux_model.Begin_Operations == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool AddressValidation(AddressModel aux_model)
        {
            if (aux_model.Street_Name == null || aux_model.House_Number == null || aux_model.Suburb_Name == null || aux_model.Zip_Code == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public DataTable FillCountriesBox() 
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOTELS_SYSTEM.COUNTRY_DATA", sqlConexion.StartConnection());
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
