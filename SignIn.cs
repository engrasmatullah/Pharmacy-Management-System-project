using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox_userName.Clear();
            textBox_password.Clear();
        }
        private void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = "datasource=localhost;port=3306;username=root;password=Asmat@391;database=pharmacy;";
                MySqlConnection myConnection = new MySqlConnection(conString);
                string Querry = "SELECT UserRole FROM user WHERE UserName = @UserName AND Password = @Password";
                MySqlCommand cmdSignIn = new MySqlCommand(Querry, myConnection);
                cmdSignIn.Parameters.AddWithValue("@UserName", textBox_userName.Text);
                cmdSignIn.Parameters.AddWithValue("@Password", textBox_password.Text);
                myConnection.Open();
                object result = cmdSignIn.ExecuteScalar();
                myConnection.Close();
                if (result != null )
                {
                    string userrole = Convert.ToString(result);
                    if (userrole == "Pharmacist")
                    {
                        MessageBox.Show("Welcom Pharmacist!");
                        Pharmacist pharm = new Pharmacist(textBox_userName.Text);
                        pharm.Show();
                        this.Hide();
                    }
                    else if (userrole == "Admin")
                    {
                        MessageBox.Show("Welcome Admin!");
                        Adminstrator admin = new Adminstrator(textBox_userName.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (userrole == "Client")
                    {
                        MessageBox.Show("Welcome Dear Client!");
                    }
                    else
                    {
                        MessageBox.Show("YourLogIn is correct but userrole is't specified .");
                    }
                }
                else
                {
                    MessageBox.Show("Your Username or Password is incorrect!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
