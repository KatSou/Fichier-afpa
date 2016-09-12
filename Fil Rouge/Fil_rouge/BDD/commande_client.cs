using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDD
{
    public class commande_client
    {
        SqlConnection _connect;

        public commande_client(string chaine)
        {
            _connect = new SqlConnection(chaine);

        }

        public List<string> recherchecommande(int i)
        {
            _connect.Open();

            List<string> commande = new List<string>();
            SqlCommand requete = new SqlCommand("select * from commande where client_reference=" + i, _connect);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                string a = lecture["commande_numero"].ToString() + " " + lecture["commande_etat"].ToString() + " " + lecture["commande_date"].ToString() + " " + lecture["facture"].ToString();
                commande.Add(a);
            }
            lecture.Close();
            _connect.Close();
            return commande;
        }
    }
}
