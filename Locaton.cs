using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Resources
{
    public partial class Locaton : Form
    {
        public Locaton()
        {
            InitializeComponent();
        }

        private void Locaton_Load(object sender, EventArgs e)
        {
            Main frm3 = new Main();
            DialogResult res3 = frm3.ShowDialog();
        }
    }
}
