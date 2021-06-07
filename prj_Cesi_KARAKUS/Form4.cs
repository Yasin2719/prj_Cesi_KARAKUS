using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_Cesi_KARAKUS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //remplir le formulaire de tout les numeros de la classe Personne
            foreach(Personne p in globale.lesPersonnes)
            {
                cbNum.Items.Add(p.getTel());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on recherche tout les informations correspondant au numero séléctionner
            if(cbNum.Text != "")
            {
                groupBox1.Visible = true;
                foreach (Personne p in globale.lesPersonnes)
                {
                    if(cbNum.Text == p.getTel())
                    {
                        tbNum.Text = p.getTel();
                        tbNom.Text = p.getNom();
                        tbPrenom.Text = p.getPrenom();
                        tbService.Text = p.getService();
                        dateTimePicker1.Text = p.getDateE().ToShortDateString();

                    }
                }
            }
            else { MessageBox.Show("choisissez un numero pour la recherche"); }
        }
    }
}
