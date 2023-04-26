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
    public partial class AddTypeOfRoomForm : Form
    {
        public AddTypeOfRoomForm()
        {
            InitializeComponent();
        }

        private void CRForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTypeOfRoom_Click(object sender, EventArgs e)
        {
            //UserModel new_user = new UserModel();
            //AddressModel new_address = new AddressModel();
            //PhoneModel new_phone = new PhoneModel();
            RoomTypeModel new_room = new RoomTypeModel();

            //new_user.Names = txtboxFirstNameOp.Text;
            //new_user.Last_Name_One = txtboxLastName1.Text;
            //new_user.Last_Name_Two = txtboxLastName2.Text;
            //new_user.Date_Birth = datetpDOB.Value;
            //new_user.Payroll_No = int.Parse(txtboxPayrollNum.Text);
            //new_user.Email = txtboxEmailOp.Text;
            //new_user.User_Password = txtboxPasswordOp.Text;
            //new_user.User_Type = cboxTypeOfUser.Text;

            //new_address.Street_Name = txtboxStreetOp.Text;
            //new_address.House_Number = txtboxHouseNoOp.Text;
            //new_address.Suburb_Name = txtboxSuburbOp.Text;
            //new_address.Zip_Code = txtboxZipCodeOp.Text;

            //new_phone.Phone_Number = txtboxHomePhoneOp.Text;
            //new_phone.Cellphone_Number = txtboxCellPhoneOp.Text;


            //bool resultuser = sqlconexion.addoperator(new_user, new_address, new_phone);

            //if (resultuser)
            //{
            //    this.hide();
            //    messagebox.show("the operator fue agregado a la base de datos.");
            //}
            //else
            //{
            //    messagebox.show("the email or password are invalid");
            //}
        }

        private bool RoomValidation(RoomTypeModel aux_model)
        {
            if (aux_model.roomType_name == null || aux_model.room_quantity == 0 || aux_model.bed_quantity == 0 ||
                aux_model.price_night == 0 || aux_model.discount == 0 || aux_model.amount_people == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
