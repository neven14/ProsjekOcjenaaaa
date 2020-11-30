using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjekOcjenaaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIspis_TextChanged(object sender, EventArgs e)
        {

        }
        int ocjena;
        int zbrojOcjena=0;
        double prosjek = 0;
        int brojOcjena = 0;
        private void BtnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                ocjena = Convert.ToInt32(txtBox.Text);
                if(ocjena <1 || ocjena > 5)
                {
                    MessageBox.Show("Upište ispravnu ocjenu", "Pogreška");
                }
                else
                {
                    brojOcjena++;
                    zbrojOcjena += ocjena;

                }
                DialogResult odgovor = MessageBox.Show("Želite li unijeti još jednu ocjenu","Izbor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odgovor == DialogResult.Yes)
                {
                    txtBox.Clear();
                }
                else
                {
                    prosjek = zbrojOcjena / brojOcjena;
                    txtBox.Text = "Prosjek je: " + prosjek;
                }
            }
            catch (Exception greska)
            {
                MessageBox.Show("Upišite ispravnu ocjenu", "Pogreška");
            }
        }
    }
}
