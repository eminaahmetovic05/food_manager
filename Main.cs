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
    public partial class Main : Form
    {   //Postavljanje cijena proizvoda
         const double Price_Pomfrit = 1.5;
         const double Price_Salata = 2.5;
        const double Price_Hamburger = 3.5;
        const double Price_Onion_ringsr = 4.2;
        const double Price_Pilecasalata = 3.5;
        const double Price_Tuna_sendvic = 2.5;
        const double Price_Cheese_sendvic = 3.2;
        const double Price_Chicken = 3.5;
        const double Price_Brownie = 1.5;
        const double Price_Toasted_Bagel = 1.5;
        const double Price_Pineapplesticks = 2.5;
        const double Price_Chocolate_muffin = 1.2;
        const double Price_Pancakes = 4.5;
        const double Price_Caj = 1.5;
        const double Price_Cola = 3.3;
        const double Price_Kafa = 2.2;
        const double Price_Orange = 3.2;
        const double Price_Voda = 0.5;
        const double Price_VanillaCone = 2.5;
        const double Price_VanillaShake = 2.5;
        const double Price_Strawberry_shake = 2.5;
        const double Price_ChocolateMilkShake = 2.5;

        double iSubTotal;

       
        public Main()
        {
            InitializeComponent();
        }

      

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Klikom na btn_exit otvara se Messagebox u kojem trebamo potvrditi da li želimo izaći iz aplikacije
            DialogResult Exit;
            Exit = MessageBox.Show("Confrim you want to Exit the System", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes) {
                Application.Exit();
            }
        }
        //reset textboxes
        private void ResetTextBoxes() { //Funkcija koja ce biti pozvana za Reset button
            Action<Control.ControlCollection> func = null; //Koristenje metode Action
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";  //Ako je control Textbox, upisi na njegovo mjesto 0
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //reset checkboxes
        private void ResetCheckBoxes()
        { 
            Action<Control.ControlCollection> func = null; 
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;  
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //Enable textboxes
        private void EnableTextBoxes()
        {
            
            Action<Control.ControlCollection> func = null; //Koristenje metode Action
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //Reset
            ResetTextBoxes();
            ResetCheckBoxes();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
            //Dodavanje Items u combobox
            
            comboBoxPayment.Items.Add("Cash");
            comboBoxPayment.Items.Add("Master Card");
     
            EnableTextBoxes();
        }

        private void chc_fries_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_fries.Checked == true)
            {
                txt_pomfrit.Enabled = true; // txt_pomfrit je enable
                txt_pomfrit.Text = "";      //Sadrzaj iz txt_pomfrit nestaje
                txt_pomfrit.Focus();        

            }
            else {
                txt_pomfrit.Enabled = false;
                txt_pomfrit.Text = "0";
            }
        }
        //provjeravanje svakog check boxa

        private void chc_salad_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_salad.Checked == true)
            {
                 txt_salata.Enabled = true; 
                txt_salata.Text = "";      
                txt_salata.Focus();

            }
            else
            {
                txt_salata.Enabled = false;
                txt_salata.Text = "0";
            }
        }

        private void chc_hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_hamburger.Checked == true)
            {
               
                txt_hamb.Enabled = true;
                txt_hamb.Text = "";
                txt_hamb.Focus();

            }
            else
            {
                txt_hamb.Enabled = false;
                txt_hamb.Text = "0";
            }
        }

        private void chc_onionrings_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_onionrings.Checked == true)
            {

                txt_onion.Enabled = true;
                txt_onion.Text = "";
                txt_onion.Focus();

            }
            else
            {
                txt_onion.Enabled = false;
                txt_onion.Text = "0";
            }
        }

        private void chc_pilecasalata_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pilecasalata.Checked == true)
            {

                txt_pilecas.Enabled = true;
                txt_pilecas.Text = "";
                txt_pilecas.Focus();

            }
            else
            {
                txt_pilecas.Enabled = false;
                txt_pilecas.Text = "0";
            }
        }

        private void chc_fish_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_fish.Checked == true)
            {
                txt_tuna.Enabled = true;
                txt_tuna.Text = "";
                txt_tuna.Focus();

            }
            else
            {
                txt_tuna.Enabled = false;
                txt_tuna.Text = "0";
            }
        }

        private void chc_cheese_sandw_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_cheese_sandw.Checked == true)
            {
                txt_cheese.Enabled = true;
                txt_cheese.Text = "";
                txt_cheese.Focus();

            }
            else
            {
                txt_cheese.Enabled = false;
                txt_cheese.Text = "0";
            }
        }

        private void chc_chicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_chicken.Checked == true)
            {
                txt_chicken.Enabled = true;
                txt_chicken.Text = "";
                txt_chicken.Focus();

            }
            else
            {
                txt_chicken.Enabled = false;
                txt_chicken.Text = "0";
            }
        }

        private void chc_brownie_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_brownie.Checked == true)
            {
                txt_brownie.Enabled = true;
                txt_brownie.Text = "";
                txt_brownie.Focus();

            }
            else
            {
                txt_brownie.Enabled = false;
                txt_brownie.Text = "0";
            }

        }

        private void chc_toast_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_toast.Checked == true)
            {
                txt_toasted.Enabled = true;
                txt_toasted.Text = "";
                txt_toasted.Focus();

            }
            else
            {
                txt_toasted.Enabled = false;
                txt_toasted.Text = "0";
            }
        }

        private void chc_pineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pineapple.Checked == true)
            {
                txt_pineapple.Enabled = true;
                txt_pineapple.Text = "";
                txt_pineapple.Focus();

            }
            else
            {
                txt_pineapple.Enabled = false;
                txt_pineapple.Text = "0";
            }
        }

        private void chc_chocolatemuffin_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_chocolatemuffin.Checked == true)
            {
                txt_chocmuf.Enabled = true;
                txt_chocmuf.Text = "";
                txt_chocmuf.Focus();

            }
            else
            {
                txt_chocmuf.Enabled = false;
                txt_chocmuf.Text = "0";
            }
        }

        private void chc_pancakes_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pancakes.Checked == true)
            {
                txt_pancakes.Enabled = true;
                txt_pancakes.Text = "";
                txt_pancakes.Focus();

            }
            else
            {
                txt_pancakes.Enabled = false;
                txt_pancakes.Text = "0";
            }

        }

        private void chc_tea_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_tea.Checked == true)
            {
                txt_tea.Enabled = true;
                txt_tea.Text = "";
                txt_tea.Focus();

            }
            else
            {
                txt_tea.Enabled = false;
                txt_tea.Text = "0";
            }
        }

        private void chc_cola_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_cola.Checked == true)
            {
                txt_cola.Enabled = true;
                txt_cola.Text = "";
                txt_cola.Focus();

            }
            else
            {
                txt_cola.Enabled = false;
                txt_cola.Text = "0";
            }
        }

        private void chc_coffee_CheckedChanged(object sender, EventArgs e)
        {

            if (chc_coffee.Checked == true)
            {
                txt_caffee.Enabled = true;
                txt_caffee.Text = "";
                txt_caffee.Focus();

            }
            else
            {
                txt_caffee.Enabled = false;
                txt_caffee.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                txt_orange.Enabled = true;
                txt_orange.Text = "";
                txt_orange.Focus();

            }
            else
            {
                txt_orange.Enabled = false;
                txt_orange.Text = "0";
            }
        }

        private void chc_bottle_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_bottle.Checked == true)
            {
                txt_voda.Enabled = true;
                txt_voda.Text = "";
                txt_voda.Focus();

            }
            else
            {
                txt_voda.Enabled = false;
                txt_voda.Text = "0";
            }

        }

        private void chc_vanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_vanilla.Checked == true)
            {
                txt_vanilla.Enabled = true;
                txt_vanilla.Text = "";
                txt_vanilla.Focus();

            }
            else
            {
                txt_vanilla.Enabled = false;
                txt_vanilla.Text = "0";
            }
        }

        private void chc_vanillashake_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_vanillashake.Checked == true)
            {
                txt_vanillashake.Enabled = true;
                txt_vanillashake.Text = "";
                txt_vanillashake.Focus();

            }
            else
            {
                txt_vanillashake.Enabled = false;
                txt_vanillashake.Text = "0";
            }
        }

        private void chc_strawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_strawberry.Checked == true)
            {
                txt_strawberry.Enabled = true;
                txt_strawberry.Text = "";
                txt_strawberry.Focus();

            }
            else
            {
                txt_strawberry.Enabled = false;
                txt_strawberry.Text = "0";
            }
        }

        private void chc_chocolatemilk_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_chocolatemilk.Checked == true)
            {
                txt_chocomilkshake.Enabled = true;
                txt_chocomilkshake.Text = "";
                txt_chocomilkshake.Focus();

            }
            else
            {
                txt_chocomilkshake.Enabled = false;
                txt_chocomilkshake.Text = "0";
            }
        }

        private void comboBoxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //--------------------------------Nacin placanja----------------
            if (comboBoxPayment.Text == "Cash")    /*ako je u comboboxu upisano "Cash" txt_payment ce biti
                                                    enabeld i korisnik ce moci unijeti iznos novca.
                                                    */

            {
                txt_payment.Enabled = true;
                txt_payment.Text = "";
                txt_payment.Focus();
            }
            else {
                txt_payment.Enabled = false;
                txt_payment.Text = "0";
                
            }
     
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            /* button Total */
            
            double[] itemcost = new double[22]; //Kreiranje niza od 22 elementa
            if (chc_fries.Checked)
            {
                itemcost[0] = Convert.ToDouble(txt_pomfrit.Text) * Price_Pomfrit; //mozenje sadrzaja textboxa sa pocetnom cijenom
            }
            if(chc_salad.Checked){

                 itemcost[1] = Convert.ToDouble(txt_salata.Text) *Price_Salata;
            }
            if (chc_hamburger.Checked)
            {
                itemcost[2] = Convert.ToDouble(txt_hamb.Text) * Price_Hamburger;
            }
            if (chc_onionrings.Checked)
            {
                itemcost[3] = Convert.ToDouble(txt_onion.Text) * Price_Onion_ringsr;
            }
            if (chc_pilecasalata.Checked)
            {
                itemcost[4] = Convert.ToDouble(txt_pilecas.Text) * Price_Pilecasalata;
            }
            if (chc_fish.Checked)
            {
                itemcost[5] = Convert.ToDouble(txt_tuna.Text) * Price_Tuna_sendvic;
            }
            if (chc_cheese_sandw.Checked)
            {
                itemcost[6] = Convert.ToDouble(txt_cheese.Text) * Price_Cheese_sendvic;
            }
            if (chc_chicken.Checked)
            {
                itemcost[7] = Convert.ToDouble(txt_chicken.Text) * Price_Chicken;
            }
            if (chc_brownie.Checked)
            {
                itemcost[8] = Convert.ToDouble(txt_brownie.Text) * Price_Brownie;
            }
            if (chc_toast.Checked)
            {
                itemcost[9] = Convert.ToDouble(txt_toasted.Text) * Price_Toasted_Bagel;
            }
            if (chc_pineapple.Checked)
            {
                itemcost[10] = Convert.ToDouble(txt_pineapple.Text) * Price_Pineapplesticks;
            }
            if (chc_chocolatemuffin.Checked)
            {
                itemcost[11] = Convert.ToDouble(txt_chocmuf.Text) * Price_Chocolate_muffin;
            }
            if (chc_pancakes.Checked)
            {
                itemcost[12] = Convert.ToDouble(txt_pancakes.Text) * Price_Pancakes;
            }
            if (chc_tea.Checked)
            {
                itemcost[13] = Convert.ToDouble(txt_tea.Text) * Price_Caj;
            }
            if (chc_cola.Checked)
            {
                itemcost[14] = Convert.ToDouble(txt_cola.Text) * Price_Cola;
            }
            if (chc_coffee.Checked)
            {
                itemcost[15] = Convert.ToDouble(txt_caffee.Text) * Price_Kafa;
            }
            if (checkBox20.Checked)
            {
                itemcost[16] = Convert.ToDouble(txt_orange.Text) * Price_Orange;
            }
            if (chc_bottle.Checked)
            {
                itemcost[17] = Convert.ToDouble(txt_voda.Text) * Price_Voda;
            }
            if (chc_vanilla.Checked)
            {
                itemcost[18] = Convert.ToDouble(txt_vanilla.Text) * Price_VanillaCone;
            }
            if (chc_vanillashake.Checked)
            {
                itemcost[19] = Convert.ToDouble(txt_vanillashake.Text) * Price_VanillaShake;
            }
            if (chc_strawberry.Checked)
            {
                itemcost[20] = Convert.ToDouble(txt_strawberry.Text) * Price_Strawberry_shake;
            }
            if (chc_chocolatemilk.Checked)
            {
                itemcost[21] = Convert.ToDouble(txt_chocomilkshake.Text) * Price_ChocolateMilkShake;
            }
            double cost, ichange;

            //--------------------------------------Cash-------------------------
            if (comboBoxPayment.Text == "Cash" )
            {    //Sabiranje odabranih elemenata niza i kreiranje zavrsnog iznosa Total
                iSubTotal = itemcost[0] + itemcost[1] +itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] +
                itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] +
                    itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18]  + itemcost[19] + itemcost[20] + itemcost[21];
                    
                lbl_subTotal.Text = Convert.ToString(iSubTotal);
                ichange = Convert.ToDouble(txt_payment.Text);
                cost = ichange - iSubTotal;
                lbl_change.Text = Convert.ToString(cost);
                

            }
            //------------------------------------------Master Card---------------
            if(comboBoxPayment.Text == "Master Card")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] +
                itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] +
                    itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] + itemcost[19] + itemcost[20] + itemcost[21];

                lbl_subTotal.Text = Convert.ToString(iSubTotal);
                ichange = Convert.ToDouble(txt_payment.Text);
                cost = ichange - iSubTotal;
                lbl_change.Text = Convert.ToString(cost);


            }
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {// Klikom na location omogućeno je otvaranje nove forme location
            StringBuilder adress = new StringBuilder();
            adress.Append("https://goo.gl/maps/YqaNaaVa9FrBjKWd7");
            Location1 f3 = new Location1();
           
            f3.Show();
            Visible = false; 
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void galleryToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Klikom na galleryToolStripMenuItem prelazi se na Gallery formu
            Gallery f5 = new Gallery (); 
            f5.Show();
            Visible = false; // sakrivanje Main forme
        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOPISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis f7 = new Popis();
            f7.Show();
            Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Narudzba primljena");
            if (chc_fries.Checked== true)
            {
                richTextBox1.Text += "Pomfrit" + Environment.NewLine;
            }

            if (chc_salad.Checked == true)
            {
                richTextBox1.Text += "Salata" + Environment.NewLine;
            }

            if (chc_hamburger.Checked == true)
            {
                richTextBox1.Text += "Hamburger" + Environment.NewLine;
            }

            if (chc_onionrings.Checked == true)
            {
                richTextBox1.Text += "Onion Rings" + Environment.NewLine;
            }

            if (chc_pilecasalata.Checked == true)
            {
                richTextBox1.Text += "Pileca salata" + Environment.NewLine;
            }

            if (chc_fish.Checked == true)
            {
                richTextBox1.Text += "Tuna sendvic" + Environment.NewLine;
            }

            if (chc_cheese_sandw.Checked == true)
            {
                richTextBox1.Text += "Cheese sendvic" + Environment.NewLine;
            }

            if (chc_chicken.Checked == true)
            {
                richTextBox1.Text += "Chicken" + Environment.NewLine;
            }

            if (chc_brownie.Checked == true)
            {
                richTextBox1.Text += "Brownie" + Environment.NewLine;
            }

            if (chc_toast.Checked == true)
            {
                richTextBox1.Text += "Toasted Bagel" + Environment.NewLine;
            }
            if (chc_pineapple.Checked== true)
            {
                richTextBox1.Text += "Pineapple" + Environment.NewLine;
            }

            if (chc_chocolatemuffin.Checked== true)
            {
                richTextBox1.Text += "Chocolate Muffin" + Environment.NewLine;
            }

            if (chc_chocolatemilk.Checked == true)
            {
                richTextBox1.Text += "Chocolate Milk Shake" + Environment.NewLine;
            }

            if (chc_vanillashake.Checked == true)
            {
                richTextBox1.Text += "Vanilla Shake" + Environment.NewLine;
            }

            if (chc_strawberry.Checked== true)
            {
                richTextBox1.Text += "Strawberry Shake" + Environment.NewLine;
            }

            if (chc_vanilla.Checked == true)
            {
                richTextBox1.Text += "Vanilla Cone" + Environment.NewLine;
            }

            if (chc_coffee.Checked == true)
            {
                richTextBox1.Text += "Kafa" + Environment.NewLine;
            }

            if (checkBox20.Checked == true)
            {
                richTextBox1.Text += "Orange" + Environment.NewLine;
            }

            if (chc_bottle.Checked== true)
            {
                richTextBox1.Text += "Voda" + Environment.NewLine;
            }

            if (chc_tea.Checked== true)
            {
                richTextBox1.Text += "Caj" + Environment.NewLine;
            }
            if (chc_cola.Checked == true)
            {
                richTextBox1.Text += "Coca Cola" + Environment.NewLine;
            }



            //-------------------------------------------------------------------------------------

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\OneDrive\Radna površina\projektni\projektni\bin\Debug\korisnik.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd;
            try
            {
                con.Close();
                con.Open();
                cmd = new SqlCommand("INSERT INTO popis(proizvodi) VALUES ('" + richTextBox1.Text +"')", con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


       

        
    }
}
