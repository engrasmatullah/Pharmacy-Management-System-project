using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Adminstrator : Form
    {
        //public Adminstrator()
        //{
        //    InitializeComponent();
        //}
        string username;
        public string ID
        {
            get { return username.ToString(); }
        }

        public Adminstrator(string user)
        {
            InitializeComponent();
            lblAdmin.Text = user;
            username = user;
            uC_Profile1.ID = ID;
        }
        

        private void button_Dashbord_Enter(object sender, EventArgs e)
        {
            button_Dashbaord.BackColor = Color.White;
            button_Dashbaord.ForeColor = Color.Black;
        }

        private void button_Dashbord_Leave(object sender, EventArgs e)
        {
            button_Dashbaord.BackColor = Color.FromArgb(64, 64, 64);
            button_Dashbaord.ForeColor = Color.White;
        }

        private void button2_Add_User_Leave(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.FromArgb(64, 64, 64);
            btnAddUser.ForeColor = Color.White;
        }

        private void button2_Add_User_Enter(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.White;
            btnAddUser.ForeColor = Color.Black;
        }
        // button 1 is view user 
        private void button1_Enter(object sender, EventArgs e)
        {
            button3_View_User.BackColor = Color.White;
            button3_View_User.ForeColor = Color.Black;
        }
        // button 3 is leaving of view user 

        private void button3_View_User_Leave(object sender, EventArgs e)
        {
            button3_View_User.BackColor = Color.FromArgb(64,64,64);
            button3_View_User.ForeColor = Color.White;
        }

        private void button4_Profile_Enter(object sender, EventArgs e)
        {
            button4_Profile.BackColor = Color.White;
            button4_Profile.ForeColor = Color.Black;
        }

        private void button4_Profile_Leave(object sender, EventArgs e)
        {
            button4_Profile.BackColor = Color.FromArgb(64, 64, 64);
            button4_Profile.ForeColor = Color.White;
        }

        private void button5_LogOut_Enter(object sender, EventArgs e)
        {
            button5_LogOut.BackColor = Color.White;
            button5_LogOut.ForeColor = Color.Black;
        }

        private void button5_LogOut_Leave(object sender, EventArgs e)
        {
            button5_LogOut.BackColor = Color.FromArgb(64, 64, 64);
            button5_LogOut.ForeColor = Color.Black;
        }

        private void button5_LogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Dasgbord1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_newuser1.Visible = false;
            uC_Profile1.Visible = false;
            uC_Reporting1.Visible = false;
            ucReportMedecine1.Visible = false;
            ucReportBills1.Visible = false;
            this.ActiveControl = panel1;
        }

        private void button_Dashbord_Click(object sender, EventArgs e)
        {
            uC_Dasgbord1.Visible = true;
            uC_Dasgbord1.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_View_User_Click(object sender, EventArgs e)
        {
            uC_newuser1.Visible = true;
            uC_newuser1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Profile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            uC_Reporting1.Visible = true;
            uC_Reporting1.BringToFront();
        }

        private void btnReporting_Enter(object sender, EventArgs e)
        {
            btnReportingUser.BackColor = Color.White;
            btnReportingUser.ForeColor = Color.Black;
        }

        private void btnReporting_Leave(object sender, EventArgs e)
        {
            btnReportingUser.BackColor = Color.FromArgb(64, 64, 64);
            btnReportingUser.ForeColor = Color.White;
        }

        private void btnReportingMedeceine_Enter(object sender, EventArgs e)
        {
            btnReportingMedeceine.BackColor = Color.White;
            btnReportingMedeceine.ForeColor = Color.Black;
        }

        private void btnReportingBills_Enter(object sender, EventArgs e)
        {
            btnReportingBills.BackColor = Color.White;
            btnReportingBills.ForeColor = Color.Black;
        }

        private void btnReportingMedeceine_Leave(object sender, EventArgs e)
        {
            btnReportingMedeceine.BackColor = Color.FromArgb(64, 64, 64);
            btnReportingMedeceine.ForeColor = Color.White;
        }

        private void btnReportingBills_Leave(object sender, EventArgs e)
        {
            btnReportingBills.BackColor = Color.FromArgb(64, 64, 64);
            btnReportingBills.ForeColor = Color.White;
        }

        private void btnReportingMedeceine_Click(object sender, EventArgs e)
        {
            ucReportMedecine1.Visible = true;
            ucReportMedecine1.BringToFront();
        }

        private void btnReportingBills_Click(object sender, EventArgs e)
        {
            ucReportBills1.Visible = true;
            ucReportBills1.BringToFront();
        }

        private void ucReportBills1_Load(object sender, EventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucReportMedecine1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Reporting1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Profile1_Load(object sender, EventArgs e)
        {

        }

        private void uC_newuser1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Dasgbord1_Load(object sender, EventArgs e)
        {

        }
    }
}
