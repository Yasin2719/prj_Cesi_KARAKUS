using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace prj_Cesi_KARAKUS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //on recharge les données de la classe Personne puis on les affiches dans une liste
            listView1.Items.Clear();
            globale.lesPersonnes.Clear();
            BDD.prc_PersonneListe();

            foreach (Personne uneP in globale.lesPersonnes)
            {
                ListViewItem maLigne = new ListViewItem();
                maLigne.Text = uneP.getId() .ToString();
                maLigne.SubItems.Add(uneP.getNom());
                maLigne.SubItems.Add(uneP.getPrenom());
                maLigne.SubItems.Add(uneP.getTel());
                maLigne.SubItems.Add(uneP.getService());
                maLigne.SubItems.Add(uneP.getDateE().ToShortDateString());

                listView1.Items.Add(maLigne);
            }
        }



        private void btAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
