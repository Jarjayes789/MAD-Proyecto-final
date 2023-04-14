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
    public partial class OperatorForm : Form
    {
        #region Attributes
        private Form activeForm = null;
        #endregion
        public OperatorForm()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {

        }

        #region Hide_&_Show_Menus
        private void customizeDesing()
        {
            //pnlSubMenuSR.Visible = false; //Hide submenu of System Reports
            //pnlSubMenuHotelM.Visible = false; //Hide submenu of Hotel Managment
        }

        private void hideSubmenu()
        {
            //if (btnAddClient.Visible == true)
            //    btnAddClient.Visible = false;
            //if (btnAddReservation.Visible == true)
            //    btnAddReservation.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            //if (subMenu.Visible == false)
            //{
            //    hideSubmenu();
            //    subMenu.Visible = true;
            //}
            //else
            //    subMenu.Visible = false;
        }
        #endregion

        private void openChildSR(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            pnlOperatorSystemChild.Controls.Add(newForm);
            pnlOperatorSystemChild.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            openChildSR(new AddClientForm());
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            openChildSR(new ReservationSystemForm());
        }
    }
}
