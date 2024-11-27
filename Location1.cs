using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Location1 : Form
    {
        public Location1()
        {
            InitializeComponent();
        }

        private void Location1_Load(object sender, EventArgs e)
        {
          
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f4 = new Main(); 
            f4.Show();
            Visible = false; 
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gallery f5 = new Gallery (); 
            f5.Show();
            Visible = false; 
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //klikom na pictureBox otvara se mapa u web browseru
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/Elektrotehni%C4%8Dka+%C5%A1kola+Tuzla/@44.5404653,18.663106,412m/data=!3m1!1e3!4m5!3m4!1s0x475ead1b106753ed:0xee6994f96836c5bb!8m2!3d44.5406584!4d18.6645517?hl=bs");

        }

        private void pOPISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis f7 = new Popis();
            f7.Show();
            Visible = false;
        }
    }
}
