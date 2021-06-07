using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_Cesi_KARAKUS
{
    class globale
    {
        public static SqlConnection cnx;
        public static List<Personne> lesPersonnes;
        public static List<Result> lesResult;
    }
}
