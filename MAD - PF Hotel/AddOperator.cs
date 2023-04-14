﻿using MAD___PF_Hotel.ConexionDB;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD___PF_Hotel
{
    public partial class AddOperator : Form
    {
        Conexion sqlConexion = new Conexion();
        public AddOperator()
        {
            InitializeComponent();
            cboxTypeOfUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTypeOfUser.Items.Add("Administrator");
            cboxTypeOfUser.Items.Add("Operator");
        }

        private void AddOperator_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOp_Click(object sender, EventArgs e)
        {
            UserModel new_user = new UserModel();
            AddressModel new_address = new AddressModel();
            PhoneModel new_phone = new PhoneModel();

            new_user.Names = txtboxFirstNameOp.Text;
            new_user.Last_Name_One = txtboxLastName1.Text;
            new_user.Last_Name_Two = txtboxLastName2.Text;
            new_user.Date_Birth = datetpDOB.Value;
            new_user.Payroll_No = int.Parse(txtboxPayrollNum.Text);
            new_user.Email = txtboxEmailOp.Text;
            new_user.User_Password = txtboxPasswordOp.Text;           
            new_user.User_Type = cboxTypeOfUser.Text;

            new_address.Street_Name = txtboxStreetOp.Text;
            new_address.House_Number = txtboxHouseNoOp.Text;
            new_address.Suburb_Name = txtboxSuburbOp.Text;
            new_address.Zip_Code = txtboxZipCodeOp.Text;

            new_phone.Phone_Number = txtboxHomePhoneOp.Text;
            new_phone.Cellphone_Number = txtboxCellPhoneOp.Text;



            bool resultUser = sqlConexion.AddOperator(new_user, new_address, new_phone);

            if (resultUser)
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
