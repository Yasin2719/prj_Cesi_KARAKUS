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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            //fonction permettant de recharger la classe Personne
            globale.lesPersonnes.Clear();
            BDD.prc_PersonneListe();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public async Task<Result> ReadUser()
        {
            //Appeler l'API randomuser
            Uri uri = new Uri("https://randomuser.me/api/?inc=name,cell");
            HttpClient myClient = new HttpClient();

            HttpResponseMessage response = await myClient.GetAsync(uri);

            Root leRoot = null;
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                leRoot = JsonConvert.DeserializeObject<Root>(content);

            }

            return leRoot.results[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = Task.Run(() => ReadUser());

            t.Wait();

            //Appel de la fonction prc_ajouterPersonne pour ajouter une personne avec les informations fournit par l'API
            if (cbService.Text != "" && dateTimePicker1.Text != "")
            {
                BDD.prc_ajouterPersonne(t.Result.name.last, t.Result.name.first, t.Result.cell, cbService.Text , dateTimePicker1.Value);
                MessageBox.Show("l'utilisateur " + t.Result.name.last + ", " + t.Result.name.first + " a bien été enregistré", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else { MessageBox.Show("erreur, une information est manquante"); }
        }
    }
}
