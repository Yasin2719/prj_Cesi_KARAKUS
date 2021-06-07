using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace prj_Cesi_KARAKUS
{
    class BDD
    {
        //fonction permettant d'afficher et d'instancier les Personnes
        public static void prc_PersonneListe()
        {
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_PersonneListe", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();
            Personne p = null;
            //boucle de lecture des étapes avec ajout dans la collection
            while (SqlExec.Read())
            {
                int pId = int.Parse(SqlExec["id"].ToString());
                string pNom = SqlExec["Nom"].ToString().Trim();
                string pPrenom = SqlExec["Prenom"].ToString().Trim();
                string pTelephone = SqlExec["Telephone"].ToString().Trim();
                string pService = SqlExec["Service"].ToString().Trim();
                DateTime pDateEntree = DateTime.Parse(SqlExec["DateEntree"].ToString().Trim());
                p = new Personne(pId, pNom, pPrenom, pTelephone, pService, pDateEntree);
                globale.lesPersonnes.Add(p);
            }
            SqlExec.Close();
        }

        //fonction permettant d'ajouter une personne dans la dans la base de données à chaque appel
        public static bool prc_ajouterPersonne(string nom, string prenom, string tel, string service, DateTime dateEntreeE)
        {
            SqlCommand maRequete = new SqlCommand("prcAddUser", globale.cnx);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter Nom = new SqlParameter("@nom", System.Data.SqlDbType.NVarChar, 255);
            Nom.Value = nom;

            SqlParameter Prenom = new SqlParameter("@prenom", System.Data.SqlDbType.NVarChar, 255);
            Prenom.Value = prenom;

            SqlParameter telephone = new SqlParameter("@tel", System.Data.SqlDbType.NVarChar, 255);
            telephone.Value = tel;

            SqlParameter Service = new SqlParameter("@service", System.Data.SqlDbType.NVarChar, 255);
            Service.Value = service;

            SqlParameter dateEntree = new SqlParameter("@dateE", System.Data.SqlDbType.Date);
            dateEntree.Value = dateEntreeE;

            maRequete.Parameters.Add(Nom);
            maRequete.Parameters.Add(Prenom);
            maRequete.Parameters.Add(telephone);
            maRequete.Parameters.Add(Service);
            maRequete.Parameters.Add(dateEntree);


            try
            {
                maRequete.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
