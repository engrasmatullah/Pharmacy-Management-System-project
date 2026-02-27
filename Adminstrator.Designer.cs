
namespace PharmacyManagementSystem
{
    partial class Adminstrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminstrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportingBills = new System.Windows.Forms.Button();
            this.btnReportingMedeceine = new System.Windows.Forms.Button();
            this.btnReportingUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.button5_LogOut = new System.Windows.Forms.Button();
            this.button4_Profile = new System.Windows.Forms.Button();
            this.button3_View_User = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.button_Dashbaord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucReportBills1 = new PharmacyManagementSystem.AdministratorUC.ucReportBills();
            this.ucReportMedecine1 = new PharmacyManagementSystem.AdministratorUC.ucReportMedecine();
            this.uC_Reporting1 = new PharmacyManagementSystem.AdministratorUC.UC_Reporting();
            this.uC_Profile1 = new PharmacyManagementSystem.AdministratorUC.UC_Profile();
            this.uC_newuser1 = new PharmacyManagementSystem.AdministratorUC.UC_newuser();
            this.uC_AddUser1 = new PharmacyManagementSystem.AdministratorUC.UC_AddUser();
            this.uC_Dasgbord1 = new PharmacyManagementSystem.AdministratorUC.UC_Dashbord();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnReportingBills);
            this.panel1.Controls.Add(this.btnReportingMedeceine);
            this.panel1.Controls.Add(this.btnReportingUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.button5_LogOut);
            this.panel1.Controls.Add(this.button4_Profile);
            this.panel1.Controls.Add(this.button3_View_User);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.button_Dashbaord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 797);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReportingBills
            // 
            this.btnReportingBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportingBills.FlatAppearance.BorderSize = 0;
            this.btnReportingBills.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportingBills.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportingBills.ForeColor = System.Drawing.Color.White;
            this.btnReportingBills.Location = new System.Drawing.Point(1, 535);
            this.btnReportingBills.Name = "btnReportingBills";
            this.btnReportingBills.Size = new System.Drawing.Size(360, 45);
            this.btnReportingBills.TabIndex = 9;
            this.btnReportingBills.Text = "Report of Bills";
            this.btnReportingBills.UseVisualStyleBackColor = false;
            this.btnReportingBills.Click += new System.EventHandler(this.btnReportingBills_Click);
            this.btnReportingBills.Enter += new System.EventHandler(this.btnReportingBills_Enter);
            this.btnReportingBills.Leave += new System.EventHandler(this.btnReportingBills_Leave);
            // 
            // btnReportingMedeceine
            // 
            this.btnReportingMedeceine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportingMedeceine.FlatAppearance.BorderSize = 0;
            this.btnReportingMedeceine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportingMedeceine.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportingMedeceine.ForeColor = System.Drawing.Color.White;
            this.btnReportingMedeceine.Location = new System.Drawing.Point(12, 484);
            this.btnReportingMedeceine.Name = "btnReportingMedeceine";
            this.btnReportingMedeceine.Size = new System.Drawing.Size(360, 45);
            this.btnReportingMedeceine.TabIndex = 8;
            this.btnReportingMedeceine.Text = "Report of Medecine";
            this.btnReportingMedeceine.UseVisualStyleBackColor = false;
            this.btnReportingMedeceine.Click += new System.EventHandler(this.btnReportingMedeceine_Click);
            this.btnReportingMedeceine.Enter += new System.EventHandler(this.btnReportingMedeceine_Enter);
            this.btnReportingMedeceine.Leave += new System.EventHandler(this.btnReportingMedeceine_Leave);
            // 
            // btnReportingUser
            // 
            this.btnReportingUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportingUser.FlatAppearance.BorderSize = 0;
            this.btnReportingUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportingUser.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportingUser.ForeColor = System.Drawing.Color.White;
            this.btnReportingUser.Location = new System.Drawing.Point(12, 433);
            this.btnReportingUser.Name = "btnReportingUser";
            this.btnReportingUser.Size = new System.Drawing.Size(360, 45);
            this.btnReportingUser.TabIndex = 7;
            this.btnReportingUser.Text = "Report Of User";
            this.btnReportingUser.UseVisualStyleBackColor = false;
            this.btnReportingUser.Click += new System.EventHandler(this.btnReporting_Click);
            this.btnReportingUser.Enter += new System.EventHandler(this.btnReporting_Enter);
            this.btnReportingUser.Leave += new System.EventHandler(this.btnReporting_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "UserName:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(136, 637);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(0, 20);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            // 
            // button5_LogOut
            // 
            this.button5_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5_LogOut.FlatAppearance.BorderSize = 0;
            this.button5_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5_LogOut.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_LogOut.ForeColor = System.Drawing.Color.White;
            this.button5_LogOut.Location = new System.Drawing.Point(12, 589);
            this.button5_LogOut.Name = "button5_LogOut";
            this.button5_LogOut.Size = new System.Drawing.Size(360, 45);
            this.button5_LogOut.TabIndex = 5;
            this.button5_LogOut.Text = "Log Out";
            this.button5_LogOut.UseVisualStyleBackColor = false;
            this.button5_LogOut.Click += new System.EventHandler(this.button5_LogOut_Click);
            this.button5_LogOut.Enter += new System.EventHandler(this.button5_LogOut_Enter);
            this.button5_LogOut.Leave += new System.EventHandler(this.button5_LogOut_Leave);
            // 
            // button4_Profile
            // 
            this.button4_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4_Profile.FlatAppearance.BorderSize = 0;
            this.button4_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4_Profile.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_Profile.ForeColor = System.Drawing.Color.White;
            this.button4_Profile.Location = new System.Drawing.Point(12, 382);
            this.button4_Profile.Name = "button4_Profile";
            this.button4_Profile.Size = new System.Drawing.Size(360, 45);
            this.button4_Profile.TabIndex = 4;
            this.button4_Profile.Text = "Profile";
            this.button4_Profile.UseVisualStyleBackColor = false;
            this.button4_Profile.Click += new System.EventHandler(this.button4_Profile_Click);
            this.button4_Profile.Enter += new System.EventHandler(this.button4_Profile_Enter);
            this.button4_Profile.Leave += new System.EventHandler(this.button4_Profile_Leave);
            // 
            // button3_View_User
            // 
            this.button3_View_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3_View_User.FlatAppearance.BorderSize = 0;
            this.button3_View_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3_View_User.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_View_User.ForeColor = System.Drawing.Color.White;
            this.button3_View_User.Location = new System.Drawing.Point(12, 331);
            this.button3_View_User.Name = "button3_View_User";
            this.button3_View_User.Size = new System.Drawing.Size(360, 45);
            this.button3_View_User.TabIndex = 3;
            this.button3_View_User.Text = "View User";
            this.button3_View_User.UseVisualStyleBackColor = false;
            this.button3_View_User.Click += new System.EventHandler(this.button3_View_User_Click);
            this.button3_View_User.Enter += new System.EventHandler(this.button1_Enter);
            this.button3_View_User.Leave += new System.EventHandler(this.button3_View_User_Leave);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(12, 280);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(360, 45);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            this.btnAddUser.Enter += new System.EventHandler(this.button2_Add_User_Enter);
            this.btnAddUser.Leave += new System.EventHandler(this.button2_Add_User_Leave);
            // 
            // button_Dashbaord
            // 
            this.button_Dashbaord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Dashbaord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Dashbaord.FlatAppearance.BorderSize = 0;
            this.button_Dashbaord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Dashbaord.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dashbaord.ForeColor = System.Drawing.Color.White;
            this.button_Dashbaord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Dashbaord.Location = new System.Drawing.Point(12, 229);
            this.button_Dashbaord.Name = "button_Dashbaord";
            this.button_Dashbaord.Size = new System.Drawing.Size(360, 45);
            this.button_Dashbaord.TabIndex = 1;
            this.button_Dashbaord.Text = "Dashboard";
            this.button_Dashbaord.UseVisualStyleBackColor = false;
            this.button_Dashbaord.Click += new System.EventHandler(this.button_Dashbord_Click);
            this.button_Dashbaord.Enter += new System.EventHandler(this.button_Dashbord_Enter);
            this.button_Dashbaord.Leave += new System.EventHandler(this.button_Dashbord_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adminstrator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucReportBills1);
            this.panel3.Controls.Add(this.ucReportMedecine1);
            this.panel3.Controls.Add(this.uC_Reporting1);
            this.panel3.Controls.Add(this.uC_Profile1);
            this.panel3.Controls.Add(this.uC_newuser1);
            this.panel3.Controls.Add(this.uC_AddUser1);
            this.panel3.Controls.Add(this.uC_Dasgbord1);
            this.panel3.Location = new System.Drawing.Point(358, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 770);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ucReportBills1
            // 
            this.ucReportBills1.BackColor = System.Drawing.Color.White;
            this.ucReportBills1.Location = new System.Drawing.Point(0, 0);
            this.ucReportBills1.Name = "ucReportBills1";
            this.ucReportBills1.Size = new System.Drawing.Size(1015, 739);
            this.ucReportBills1.TabIndex = 6;
            this.ucReportBills1.Load += new System.EventHandler(this.ucReportBills1_Load);
            // 
            // ucReportMedecine1
            // 
            this.ucReportMedecine1.BackColor = System.Drawing.Color.White;
            this.ucReportMedecine1.Location = new System.Drawing.Point(0, 0);
            this.ucReportMedecine1.Name = "ucReportMedecine1";
            this.ucReportMedecine1.Size = new System.Drawing.Size(1015, 739);
            this.ucReportMedecine1.TabIndex = 5;
            this.ucReportMedecine1.Load += new System.EventHandler(this.ucReportMedecine1_Load);
            // 
            // uC_Reporting1
            // 
            this.uC_Reporting1.BackColor = System.Drawing.Color.White;
            this.uC_Reporting1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Reporting1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reporting1.Name = "uC_Reporting1";
            this.uC_Reporting1.Size = new System.Drawing.Size(1015, 782);
            this.uC_Reporting1.TabIndex = 4;
            this.uC_Reporting1.Load += new System.EventHandler(this.uC_Reporting1_Load);
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(0, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1049, 794);
            this.uC_Profile1.TabIndex = 3;
            this.uC_Profile1.Load += new System.EventHandler(this.uC_Profile1_Load);
            // 
            // uC_newuser1
            // 
            this.uC_newuser1.BackColor = System.Drawing.Color.White;
            this.uC_newuser1.Location = new System.Drawing.Point(0, 0);
            this.uC_newuser1.Name = "uC_newuser1";
            this.uC_newuser1.Size = new System.Drawing.Size(1049, 797);
            this.uC_newuser1.TabIndex = 2;
            this.uC_newuser1.Load += new System.EventHandler(this.uC_newuser1_Load);
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1049, 770);
            this.uC_AddUser1.TabIndex = 1;
            this.uC_AddUser1.Load += new System.EventHandler(this.uC_AddUser1_Load);
            // 
            // uC_Dasgbord1
            // 
            this.uC_Dasgbord1.BackColor = System.Drawing.Color.White;
            this.uC_Dasgbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dasgbord1.Name = "uC_Dasgbord1";
            this.uC_Dasgbord1.Size = new System.Drawing.Size(1148, 770);
            this.uC_Dasgbord1.TabIndex = 0;
            this.uC_Dasgbord1.Load += new System.EventHandler(this.uC_Dasgbord1_Load);
            // 
            // Adminstrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1506, 794);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminstrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminstrator";
            this.Load += new System.EventHandler(this.Adminstrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5_LogOut;
        private System.Windows.Forms.Button button4_Profile;
        private System.Windows.Forms.Button button3_View_User;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button button_Dashbaord;
        private System.Windows.Forms.Panel panel3;
        private AdministratorUC.UC_Dashbord uC_Dasgbord1;
        private AdministratorUC.UC_AddUser uC_AddUser1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label2;
        private AdministratorUC.UC_newuser uC_newuser1;
        private AdministratorUC.UC_Profile uC_Profile1;
        private System.Windows.Forms.Button btnReportingUser;
        private AdministratorUC.UC_Reporting uC_Reporting1;
        private System.Windows.Forms.Button btnReportingBills;
        private System.Windows.Forms.Button btnReportingMedeceine;
        private AdministratorUC.ucReportMedecine ucReportMedecine1;
        private AdministratorUC.ucReportBills ucReportBills1;
    }
}