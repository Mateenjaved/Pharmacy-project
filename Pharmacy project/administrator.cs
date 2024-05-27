using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_project
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashborad1.Visible = true;
            uC_Dashborad1.BringToFront();
        }

        private void administrator_Load(object sender, EventArgs e)
        {
            uC_Dashborad1.Visible = false;
            uC_AddUser1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
