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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //initialiser la connection a la base de données et chargement de la classe objet Personne
            globale.cnx = new System.Data.SqlClient.SqlConnection();
            //remplacez la valeur de nomPoste par le nom de votre poste
            string nomPoste = "HPG6-18";
            globale.cnx.ConnectionString = "Data Source=" + nomPoste + "\\SQLEXPRESS;Initial Catalog=BDD_Cesi;Integrated Security=True;MultipleActiveResultSets=True";
            globale.cnx.Open();

            globale.lesPersonnes = new List<Personne>();

            BDD.prc_PersonneListe();
            
        }

        

        private void listeContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.MdiParent = this;
            f1.Show();

        }

        private void rechercheContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.MdiParent = this;
            f2.Show();
        }

        private void détailContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.MdiParent = this;
            f3.Show();
        }

        private void ajouterUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f4 = new Form5();
            f4.MdiParent = this;
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
