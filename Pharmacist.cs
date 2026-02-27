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
    public partial class Pharmacist : Form
    {
        public Pharmacist(string pharma)
        {
            InitializeComponent();
            labelPHarmacist.Text = pharma;
            uCdashboardP1.Visible = false;
            uC_AddMedecine1.Visible = false;
            uC_ViewMedecine1.Visible = false;
            uC_pValidCheck1.Visible = false;
            uC_SellMedecine1.Visible = false;
        }

        private void btnDashbaord_Enter(object sender, EventArgs e)
        {
            btnDashbaord.BackColor = Color.White;
            btnDashbaord.ForeColor = Color.Black;
        }
        private void btnDashbaord_Leave(object sender, EventArgs e)
        {
            btnDashbaord.BackColor = Color.FromArgb(0, 118, 225);
            btnDashbaord.ForeColor = Color.White;
        }
        private void btnAddMedecine_Enter(object sender, EventArgs e)
        {
            btnAddMedecine.BackColor = Color.White;
            btnAddMedecine.ForeColor = Color.Black;
        }
        private void btnAddMedecine_Leave(object sender, EventArgs e)
        {
            btnAddMedecine.BackColor = Color.FromArgb(0, 118, 225);
            btnAddMedecine.ForeColor = Color.White;
        }
        private void btnViewUser_Enter(object sender, EventArgs e)
        {
            btnViewUser.BackColor = Color.White;
            btnViewUser.ForeColor = Color.Black;
        }
        private void btnViewUser_Leave(object sender, EventArgs e)
        {
            btnViewUser.BackColor = Color.FromArgb(0, 118, 225);
            btnViewUser.ForeColor = Color.White;
        }
        private void btnModifyMedecine_Enter(object sender, EventArgs e)
        {
            
        }
        private void btnModifyMedecine_Leave(object sender, EventArgs e)
        {
            
        }
        private void btnCellMedecine_Enter(object sender, EventArgs e)
        {
            btnSellMedecine.BackColor = Color.White;
            btnSellMedecine.ForeColor = Color.Black;
        }
        private void btnCellMedecine_Leave(object sender, EventArgs e)
        {
            btnSellMedecine.BackColor = Color.FromArgb(0, 118, 225);
            btnSellMedecine.ForeColor = Color.White;
        }
        private void btnValidCh_Enter(object sender, EventArgs e)
        {
            btnValidCh.BackColor = Color.White;
            btnValidCh.ForeColor = Color.Black;
        }
        private void btnValidCh_Leave(object sender, EventArgs e)
        {
            btnValidCh.BackColor = Color.FromArgb(0, 118, 225);
            btnValidCh.ForeColor = Color.White;
        }
        private void btnLogOut_Enter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.White;
            btnLogOut.ForeColor = Color.Black;
        }
        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.FromArgb(0, 118, 225);
            btnLogOut.ForeColor = Color.White;
        }
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void btnDashbaord_Click(object sender, EventArgs e)
        {
            uCdashboardP1.Visible = true;
            uCdashboardP1.BringToFront();
        }

        private void btnAddMedecine_Click(object sender, EventArgs e)
        {
            uC_AddMedecine1.Visible = true;
            uC_AddMedecine1.BringToFront();
        }

        private void uC_AddMedecine1_Load(object sender, EventArgs e)
        {

        }

        private void labelPHarmacist_Click(object sender, EventArgs e)
        {

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewMedecine1.Visible = true;
            uC_ViewMedecine1.BringToFront();
        }

        private void uC_ViewMedecine1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidCh_Click(object sender, EventArgs e)
        {
            uC_pValidCheck1.Visible = true;
            uC_pValidCheck1.BringToFront();
        }

        private void btnCellMedecine_Click(object sender, EventArgs e)
        {
            uC_SellMedecine1.Visible = true;
            uC_SellMedecine1.BringToFront();
        }
    }
}
