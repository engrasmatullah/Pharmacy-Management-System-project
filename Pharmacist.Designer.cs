
namespace PharmacyManagementSystem
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPHarmacist = new System.Windows.Forms.Label();
            this.btnValidCh = new System.Windows.Forms.Button();
            this.btnSellMedecine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnAddMedecine = new System.Windows.Forms.Button();
            this.btnDashbaord = new System.Windows.Forms.Button();
            this.labelPharma = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SellMedecine1 = new PharmacyManagementSystem.PharmacistUC.UC_SellMedecine();
            this.uC_pValidCheck1 = new PharmacyManagementSystem.PharmacistUC.UC_pValidCheck();
            this.uC_ViewMedecine1 = new PharmacyManagementSystem.PharmacistUC.UC_ViewMedecine();
            this.uC_AddMedecine1 = new PharmacyManagementSystem.PharmacistUC.UC_AddMedecine();
            this.uCdashboardP1 = new PharmacyManagementSystem.PharmacistUC.UCdashboardP();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.labelPHarmacist);
            this.panel1.Controls.Add(this.btnValidCh);
            this.panel1.Controls.Add(this.btnSellMedecine);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnAddMedecine);
            this.panel1.Controls.Add(this.btnDashbaord);
            this.panel1.Controls.Add(this.labelPharma);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 797);
            this.panel1.TabIndex = 7;
            // 
            // labelPHarmacist
            // 
            this.labelPHarmacist.AutoSize = true;
            this.labelPHarmacist.ForeColor = System.Drawing.Color.White;
            this.labelPHarmacist.Location = new System.Drawing.Point(152, 592);
            this.labelPHarmacist.Name = "labelPHarmacist";
            this.labelPHarmacist.Size = new System.Drawing.Size(88, 20);
            this.labelPHarmacist.TabIndex = 2;
            this.labelPHarmacist.Text = "Pharmacist";
            this.labelPHarmacist.Click += new System.EventHandler(this.labelPHarmacist_Click);
            // 
            // btnValidCh
            // 
            this.btnValidCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnValidCh.FlatAppearance.BorderSize = 0;
            this.btnValidCh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidCh.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidCh.ForeColor = System.Drawing.Color.White;
            this.btnValidCh.Location = new System.Drawing.Point(12, 396);
            this.btnValidCh.Name = "btnValidCh";
            this.btnValidCh.Size = new System.Drawing.Size(359, 57);
            this.btnValidCh.TabIndex = 5;
            this.btnValidCh.Text = "Medecine Validity Check";
            this.btnValidCh.UseVisualStyleBackColor = false;
            this.btnValidCh.Click += new System.EventHandler(this.btnValidCh_Click);
            this.btnValidCh.Enter += new System.EventHandler(this.btnValidCh_Enter);
            this.btnValidCh.Leave += new System.EventHandler(this.btnValidCh_Leave);
            // 
            // btnSellMedecine
            // 
            this.btnSellMedecine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMedecine.FlatAppearance.BorderSize = 0;
            this.btnSellMedecine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellMedecine.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedecine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedecine.Location = new System.Drawing.Point(12, 459);
            this.btnSellMedecine.Name = "btnSellMedecine";
            this.btnSellMedecine.Size = new System.Drawing.Size(359, 57);
            this.btnSellMedecine.TabIndex = 7;
            this.btnSellMedecine.Text = "Sell Medecine";
            this.btnSellMedecine.UseVisualStyleBackColor = false;
            this.btnSellMedecine.Click += new System.EventHandler(this.btnCellMedecine_Click);
            this.btnSellMedecine.Enter += new System.EventHandler(this.btnCellMedecine_Enter);
            this.btnSellMedecine.Leave += new System.EventHandler(this.btnCellMedecine_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "PharmacistName:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(136, 637);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(0, 20);
            this.lblAdmin.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(12, 522);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(359, 57);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.Enter += new System.EventHandler(this.btnLogOut_Enter);
            this.btnLogOut.Leave += new System.EventHandler(this.btnLogOut_Leave);
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewUser.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Location = new System.Drawing.Point(12, 333);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(359, 57);
            this.btnViewUser.TabIndex = 3;
            this.btnViewUser.Text = "View and Update Medecine";
            this.btnViewUser.UseVisualStyleBackColor = false;
            this.btnViewUser.Click += new System.EventHandler(this.btnViewUser_Click);
            this.btnViewUser.Enter += new System.EventHandler(this.btnViewUser_Enter);
            this.btnViewUser.Leave += new System.EventHandler(this.btnViewUser_Leave);
            // 
            // btnAddMedecine
            // 
            this.btnAddMedecine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedecine.FlatAppearance.BorderSize = 0;
            this.btnAddMedecine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMedecine.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedecine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedecine.Location = new System.Drawing.Point(12, 270);
            this.btnAddMedecine.Name = "btnAddMedecine";
            this.btnAddMedecine.Size = new System.Drawing.Size(359, 57);
            this.btnAddMedecine.TabIndex = 2;
            this.btnAddMedecine.Text = "Add Medecine";
            this.btnAddMedecine.UseVisualStyleBackColor = false;
            this.btnAddMedecine.Click += new System.EventHandler(this.btnAddMedecine_Click);
            this.btnAddMedecine.Enter += new System.EventHandler(this.btnAddMedecine_Enter);
            this.btnAddMedecine.Leave += new System.EventHandler(this.btnAddMedecine_Leave);
            // 
            // btnDashbaord
            // 
            this.btnDashbaord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashbaord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashbaord.FlatAppearance.BorderSize = 0;
            this.btnDashbaord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashbaord.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbaord.ForeColor = System.Drawing.Color.White;
            this.btnDashbaord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashbaord.Location = new System.Drawing.Point(12, 207);
            this.btnDashbaord.Name = "btnDashbaord";
            this.btnDashbaord.Size = new System.Drawing.Size(359, 57);
            this.btnDashbaord.TabIndex = 1;
            this.btnDashbaord.Text = "Dashboard";
            this.btnDashbaord.UseVisualStyleBackColor = false;
            this.btnDashbaord.Click += new System.EventHandler(this.btnDashbaord_Click);
            this.btnDashbaord.Enter += new System.EventHandler(this.btnDashbaord_Enter);
            this.btnDashbaord.Leave += new System.EventHandler(this.btnDashbaord_Leave);
            // 
            // labelPharma
            // 
            this.labelPharma.AutoSize = true;
            this.labelPharma.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPharma.ForeColor = System.Drawing.Color.White;
            this.labelPharma.Location = new System.Drawing.Point(35, 155);
            this.labelPharma.Name = "labelPharma";
            this.labelPharma.Size = new System.Drawing.Size(249, 59);
            this.labelPharma.TabIndex = 0;
            this.labelPharma.Text = "Pharmacist";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_SellMedecine1);
            this.panel2.Controls.Add(this.uC_pValidCheck1);
            this.panel2.Controls.Add(this.uC_ViewMedecine1);
            this.panel2.Controls.Add(this.uC_AddMedecine1);
            this.panel2.Controls.Add(this.uCdashboardP1);
            this.panel2.Location = new System.Drawing.Point(358, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 775);
            this.panel2.TabIndex = 8;
            // 
            // uC_SellMedecine1
            // 
            this.uC_SellMedecine1.BackColor = System.Drawing.Color.White;
            this.uC_SellMedecine1.Location = new System.Drawing.Point(0, 0);
            this.uC_SellMedecine1.Name = "uC_SellMedecine1";
            this.uC_SellMedecine1.Size = new System.Drawing.Size(1019, 743);
            this.uC_SellMedecine1.TabIndex = 4;
            // 
            // uC_pValidCheck1
            // 
            this.uC_pValidCheck1.BackColor = System.Drawing.Color.White;
            this.uC_pValidCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_pValidCheck1.Name = "uC_pValidCheck1";
            this.uC_pValidCheck1.Size = new System.Drawing.Size(1019, 794);
            this.uC_pValidCheck1.TabIndex = 3;
            // 
            // uC_ViewMedecine1
            // 
            this.uC_ViewMedecine1.BackColor = System.Drawing.Color.White;
            this.uC_ViewMedecine1.Location = new System.Drawing.Point(0, 0);
            this.uC_ViewMedecine1.Name = "uC_ViewMedecine1";
            this.uC_ViewMedecine1.Size = new System.Drawing.Size(1019, 794);
            this.uC_ViewMedecine1.TabIndex = 2;
            this.uC_ViewMedecine1.Load += new System.EventHandler(this.uC_ViewMedecine1_Load);
            // 
            // uC_AddMedecine1
            // 
            this.uC_AddMedecine1.BackColor = System.Drawing.Color.White;
            this.uC_AddMedecine1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddMedecine1.Name = "uC_AddMedecine1";
            this.uC_AddMedecine1.Size = new System.Drawing.Size(1146, 794);
            this.uC_AddMedecine1.TabIndex = 1;
            this.uC_AddMedecine1.Load += new System.EventHandler(this.uC_AddMedecine1_Load);
            // 
            // uCdashboardP1
            // 
            this.uCdashboardP1.BackColor = System.Drawing.Color.White;
            this.uCdashboardP1.Location = new System.Drawing.Point(0, 0);
            this.uCdashboardP1.Name = "uCdashboardP1";
            this.uCdashboardP1.Size = new System.Drawing.Size(1092, 794);
            this.uCdashboardP1.TabIndex = 0;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1506, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Button btnAddMedecine;
        private System.Windows.Forms.Button btnDashbaord;
        private System.Windows.Forms.Label labelPharma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnValidCh;
        private System.Windows.Forms.Button btnSellMedecine;
        private PharmacistUC.UCdashboardP uCdashboardP1;
        private PharmacistUC.UC_AddMedecine uC_AddMedecine1;
        private System.Windows.Forms.Label labelPHarmacist;
        private PharmacistUC.UC_ViewMedecine uC_ViewMedecine1;
        private PharmacistUC.UC_pValidCheck uC_pValidCheck1;
        private PharmacistUC.UC_SellMedecine uC_SellMedecine1;
    }
}