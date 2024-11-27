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
    public partial class Popis : Form
    {
        public Popis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;

            



           
        }

        private void Popis_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            // TODO: This line of code loads data into the 'korisnikDataSet4.popis' table. You can move, or remove it, as needed.
            this.popisTableAdapter.Fill(this.korisnikDataSet4.popis);



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lOCATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location1 f3 = new Location1();

            f3.Show();
            Visible = false; 
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Main f1 = new Main();

            f1.Show();
            Visible = false; 
        }

        private void gALLERYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gallery f3 = new Gallery();

            f3.Show();
            Visible = false; 
        }
    }
}
