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
    public partial class Gallery : Form
    {
        private int ImageNumber = 1;
        public Gallery()
        {
            InitializeComponent();
        }

        

      


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f6 = new Main();
            f6.Show();
            Visible = false;
        }
        
        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            Location1 f7 = new Location1 ();
            f7.Show();
            Visible = false;
        }

       

        private void Slider() {
            //formiranje Slidera
            if (ImageNumber == 5) {
                ImageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {    //postavljanje timera
            Slider();
        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOPISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis f7 = new Popis();
            f7.Show();
            Visible = false;
        }
    }
}
