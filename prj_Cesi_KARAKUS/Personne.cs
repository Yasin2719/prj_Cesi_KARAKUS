using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_Cesi_KARAKUS
{
    class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string service;
        private DateTime dateEntree;

        public Personne(int leId, string lNom, string lPrenom, string tel, string serv, DateTime date)
        {
            this.id = leId;
            this.nom = lNom;
            this.prenom = lPrenom;
            this.telephone = tel;
            this.service = serv;
            this.dateEntree = date;
        }

        public int getId() { return this.id; }
        public string getNom() { return this.nom; }
        public string getPrenom() { return this.prenom; }
        public string getTel() { return this.telephone; }
        public string getService() { return this.service; }
        public DateTime getDateE() { return this.dateEntree; }
    }
}
