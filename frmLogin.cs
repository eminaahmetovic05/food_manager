using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\OneDrive\Radna površina\projektni\projektni\bin\Debug\korisnik.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM korisnik WHERE ime='" + textBox1.Text + "'and password='" + txtPass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Main f = new Main();
                this.Hide();
                f.ShowDialog();
            }

            else
            {
                MessageBox.Show("Invalid username or password, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                txtPass.Text = "";
                txtPass.BackColor = Color.Tomato;
            }
        }
        


        

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show.Checked)       // checkbox za prikaz i sakrivanje txtPass
            {
                txtPass.UseSystemPasswordChar = false; 
            }
            else {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            this.Hide();
            f.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
