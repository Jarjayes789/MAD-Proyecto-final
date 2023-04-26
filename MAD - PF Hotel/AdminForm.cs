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
    public partial class AdminForm : Form
    {
        #region Attributes
        private Form activeForm = null;
        #endregion

        public AdminForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        #region Hide_&_Show_Menus
        private void customizeDesing()
        {
            pnlSubMenuSR.Visible = false; //Hide submenu of System Reports
            pnlSubMenuHotelM.Visible = false; //Hide submenu of Hotel Management
            pnlSubMenuEmployee.Visible = false; //Hide submenu of Employee Management
            pnlSubMenuReservation.Visible = false;
        }
        
        private void hideSubmenu() 
        {
            if (pnlSubMenuSR.Visible == true)
                pnlSubMenuSR.Visible = false;
            if (pnlSubMenuHotelM.Visible == true)
                pnlSubMenuHotelM.Visible = false;
            if (pnlSubMenuEmployee.Visible == true)
                pnlSubMenuEmployee.Visible = false;
            if (pnlSubMenuReservation.Visible == true)
                pnlSubMenuReservation.Visible = false;
        }
        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region System_Report
        private void btnSR_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuSR);
        }

        #region System_ReportSM
        /*private void button2_Click(object sender, EventArgs e)
        {
            //Don´t forget to place the next method in every button from the app
            hideSubmenu();
        }*/

        private void btnSubSR_Click(object sender, EventArgs e)
        {
            openChildSR(new ReportForSalesForm());
            hideSubmenu();
        }

        private void btnSubCR_Click(object sender, EventArgs e)
        {           
            hideSubmenu();
        }
        private void btnSubHOR_Click(object sender, EventArgs e)
        {
            openChildSR(new ReportForHotelOcupForm());
            hideSubmenu();
        }
        #endregion

        #endregion

        #region Cancel_Reservation
        private void btnReservations_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuReservation);
        }
        #endregion

        #region Hotel_Managment
        private void btnHM_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuHotelM);
        }
        #endregion

        #region User_Managment
        private void btnUM_Click(object sender, EventArgs e)
        {
        #endregion
        }

        private void pnlSRChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openChildSR(Form newForm)
        {
            if (activeForm!=null) 
                activeForm.Close();

                activeForm = newForm;
                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;
                pnlSRChild.Controls.Add(newForm);
                pnlSRChild.Tag = newForm;
                newForm.BringToFront();
                newForm.Show();
            
        }
        #region Hotel
        private void btnSubAddHotel_Click(object sender, EventArgs e)
        {
            openChildSR(new AddHotelForm());
            hideSubmenu();          
        }


        private void btnSMAddToR_Click(object sender, EventArgs e)
        {
            openChildSR(new AddTypeOfRoomForm());
            hideSubmenu(); 
        }
        #endregion

        #region Employee Management
        private void btnEmployeeManagment_Click(object sender, EventArgs e)
        {
            //openChildSR(new AddTypeOfRoomForm());
            showSubMenu(pnlSubMenuEmployee);
            //hideSubmenu();
        }
        private void btnSMAddEmployee_Click(object sender, EventArgs e)
        {
            openChildSR(new AddOperator());
            hideSubmenu();
        }
        #endregion

    }
}
