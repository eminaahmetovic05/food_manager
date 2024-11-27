using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\OneDrive\Radna površina\projektni\projektni\bin\Debug\korisnik.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd;
            if (ime.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Unesite sva polja!");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO korisnik(ime, password) VALUES ('" + ime.Text + "','" + pass.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();

                    MessageBox.Show("Registracije uspjesna. Kliknite na Login");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin f9 = new frmLogin();
            this.Hide();
            f9.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
