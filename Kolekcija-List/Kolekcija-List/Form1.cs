using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcija_List
{
    public partial class Form1 : Form
    {
        List<Ucenik>ucenici=new List<Ucenik>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = new Ucenik(txtboxIme.Text, txtBoxPrezime.Text, comboBoxRazred.Text);
                
                ucenici.Add(ucenik);

                txtboxIme.Clear();
                txtBoxPrezime.Clear();

                MessageBox.Show("Uspješan unos!\r\n", "Obavijest",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtBoxIspis.Text = "Ime" + "\tPrezime" + "\tRazred\r\n";

            foreach(Ucenik ucenik in ucenici)
            {
                rtBoxIspis.AppendText(ucenik.ToString()+"\r\n");

            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach(Ucenik ucenik in ucenici)
            {
                if (ucenik.Razred == "2.")
                {
                    ucenik.Razred = "3.";
                }
            }

            rtBoxIspis.Text = "Ime" + "\tPrezime" + "\tRazred\r\n";

            foreach (Ucenik ucenik in ucenici)
            {
                rtBoxIspis.AppendText(ucenik.ToString() + "\r\n");

            }
        }
    }
}
