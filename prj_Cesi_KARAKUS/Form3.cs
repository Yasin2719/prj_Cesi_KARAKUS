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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tbInfo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btRecherche_Click(object sender, EventArgs e)
        {
            // on recherche dans la classe Personne si le champs renseigné correspond nom, prenom ou à un numero de telephone d'une ou plusieurs personnes et affiche ce contact
            listView1.Items.Clear();
            Boolean trouve = false;
            string txt = tbInfo.Text;
            foreach (Personne uneP in globale.lesPersonnes)
            {
                if (txt.ToUpper() == uneP.getNom().ToUpper() || uneP.getPrenom().ToUpper() == txt.ToUpper() || uneP.getTel() == txt)
                {
                    ListViewItem maLigne = new ListViewItem();
                    maLigne.Text = uneP.getId().ToString();
                    maLigne.SubItems.Add(uneP.getNom());
                    maLigne.SubItems.Add(uneP.getPrenom());
                    maLigne.SubItems.Add(uneP.getTel());
                    maLigne.SubItems.Add(uneP.getService());
                    maLigne.SubItems.Add(uneP.getDateE().ToShortDateString());
                    listView1.Items.Add(maLigne);
                    listView1.Visible = true;
                    trouve = true;
                }
                
            }
            if (trouve == false)
            {
                //affiche un message d'erreur si aucun contact n'a était trouver
                MessageBox.Show("Aucun Contact n'a été trouver", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
