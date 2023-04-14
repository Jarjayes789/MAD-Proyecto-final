using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MAD___PF_Hotel.Models;

namespace MAD___PF_Hotel.ConexionDB
{
    internal class Conexion
    {
        private SqlConnection con = new SqlConnection();

        static string Server = "DESKTOP-BEGKO7S";
        static string DataBase = "BOOKING_SYSTEM_DB";
        static string UserName = "sa";
        static string Password = "hola12345";
        static string Port = "1433";

        string Connection = "Server = " + Server + ";" + "database = " + DataBase + ";" + "integrated security = true";
    
        public SqlConnection StartConnection ()
        {
            try 
            {
                con.ConnectionString = Connection;
                con.Open();
            }
            catch (SqlException e) 
            {
                MessageBox.Show("No se logró conectar a la base de datos: " + e.ToString());
            }

            return con;
        }

        public int Login(string email, string password) 
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("spLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_email", email);
                cmd.Parameters.AddWithValue("p_password", password);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    //if (dr.GetInt32(11) == 0) {
                    //    return 0;
                    //}
                    //else if (dr.GetInt32(11) == 1)
                    //{ 
                    //    return 1;
                    //}
                    //else {
                    //    return 2;
                    //}
                    return dr.GetInt32(0);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Los datos ingresados no coinciden." + e.ToString());
            }
            finally 
            { 
                con.Close();
            }

            return 0; 
        
        }

        public bool AddOperator(UserModel added_User, AddressModel added_address, PhoneModel added_phone)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_u = new SqlCommand("spAddOperator", con);
                cmd_u.CommandType = CommandType.StoredProcedure;
                cmd_u.Parameters.AddWithValue("@p_first_name", added_User.Names);
                cmd_u.Parameters.AddWithValue("@p_last_name_one", added_User.Last_Name_One);
                cmd_u.Parameters.AddWithValue("@p_last_name_two", added_User.Last_Name_Two);
                cmd_u.Parameters.AddWithValue("@p_payroll_no", added_User.Payroll_No);
                cmd_u.Parameters.AddWithValue("@p_date_birth", added_User.Date_Birth);
                cmd_u.Parameters.AddWithValue("@p_email", added_User.Email);
                cmd_u.Parameters.AddWithValue("@p_user_password", added_User.User_Password);

                cmd_u.Parameters.AddWithValue("@p_street_name", added_address.Street_Name);
                cmd_u.Parameters.AddWithValue("@p_house_number", added_address.House_Number);
                cmd_u.Parameters.AddWithValue("@p_suburb_name", added_address.Suburb_Name);
                cmd_u.Parameters.AddWithValue("@p_zipcode", added_address.Zip_Code);

                cmd_u.Parameters.AddWithValue("@p_house_phone", added_phone.Phone_Number);
                cmd_u.Parameters.AddWithValue("@p_cell_phone", added_phone.Cellphone_Number);


                SqlDataReader dr = cmd_u.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetBoolean(0);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool AddHotel(HotelModel added_Hotel, AddressModel added_address)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_h = new SqlCommand("spAddHotel", con);
                cmd_h.CommandType = CommandType.StoredProcedure;
                cmd_h.Parameters.AddWithValue("@p_hotel_name", added_Hotel.Hotel_Name);
                cmd_h.Parameters.AddWithValue("@p_number_floors", added_Hotel.Number_Floors);
                cmd_h.Parameters.AddWithValue("@p_number_rooms", added_Hotel.Number_Rooms);
                cmd_h.Parameters.AddWithValue("@p_begin_operation", added_Hotel.Begin_Operations);

                cmd_h.Parameters.AddWithValue("@p_street_name", added_address.Street_Name);
                cmd_h.Parameters.AddWithValue("@p_house_number", added_address.House_Number);
                cmd_h.Parameters.AddWithValue("@p_suburb_name", added_address.Suburb_Name);
                cmd_h.Parameters.AddWithValue("@p_zipcode", added_address.Zip_Code);

                SqlDataReader dr = cmd_h.ExecuteReader();

                if (dr.Read()) {
                    return dr.GetBoolean(0);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }

            return false;
        }

        public bool AddClient(ClientModel added_client, AddressModel added_address, PhoneModel added_phone)
        {
            try
            {
                con.ConnectionString = Connection;
                con.Open();

                SqlCommand cmd_c = new SqlCommand("spAddClient", con);
                cmd_c.CommandType = CommandType.StoredProcedure;
                cmd_c.Parameters.AddWithValue("@p_hotel_name", added_client.Names);
                cmd_c.Parameters.AddWithValue("@p_number_floors", added_client.Last_Name_One);
                cmd_c.Parameters.AddWithValue("@p_number_rooms", added_client.Last_Name_Two);
                cmd_c.Parameters.AddWithValue("@p_begin_operation", added_client.Email);
                cmd_c.Parameters.AddWithValue("@p_number_floors", added_client.RFC);
                cmd_c.Parameters.AddWithValue("@p_number_rooms", added_client.Marital_Status);
                cmd_c.Parameters.AddWithValue("@p_begin_operation", added_client.Date_Birth);

                cmd_c.Parameters.AddWithValue("@p_street_name", added_address.Street_Name);
                cmd_c.Parameters.AddWithValue("@p_house_number", added_address.House_Number);
                cmd_c.Parameters.AddWithValue("@p_suburb_name", added_address.Suburb_Name);
                cmd_c.Parameters.AddWithValue("@p_zipcode", added_address.Zip_Code);

                cmd_c.Parameters.AddWithValue("@p_house_phone", added_phone.Phone_Number);
                cmd_c.Parameters.AddWithValue("@p_cell_phone", added_phone.Cellphone_Number);

                SqlDataReader dr = cmd_c.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetBoolean(0);
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("The data don´t apply on this format." + e.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }

            return false;
        }

    }
}
