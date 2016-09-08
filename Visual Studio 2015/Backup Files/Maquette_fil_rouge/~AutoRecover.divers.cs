using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDD
{
    public class divers
    {

        SqlConnection _connect;
        public  divers()
        {
            _connect = new SqlConnection("server=.;database=Fil_rouge;integrated security = true");
            

        }

        public int nb_client (int i)
        {
            _connect.Open();
            SqlCommand nbrs = new SqlCommand("select COUNT(client_reference) from client where client_categorie = @categorie", _connect);
            nbrs.Parameters.AddWithValue("@categorie", i);
            int a = (int)nbrs.ExecuteScalar();
            _connect.Close();
            return a;
        }

        public int ca(int i)
        {
            _connect.Open();
            SqlCommand ca = new SqlCommand("select AVG(prix_total) from Sont_present,Commande,Client where Sont_present.commande_numero = Commande.commande_numero and Commande.client_reference = Client.client_reference and client_categorie = @categorie", _connect);
            ca.Parameters.AddWithValue("@categorie", i);
            int a = (int)ca.ExecuteScalar();
            _connect.Close();
            return a;
        }

        public int catotalclient(int i)
        {
            _connect.Open();
            SqlCommand ca = new SqlCommand("select SUM(prix_total) from Sont_present,Commande,Client where Sont_present.commande_numero = Commande.commande_numero and Commande.client_reference = Client.client_reference and client_categorie = @categorie", _connect);
            ca.Parameters.AddWithValue("@categorie", i);
            int a = (int)ca.ExecuteScalar();
            _connect.Close();
            return a;
        }

        public int catotal(int i)
        {
            _connect.Open();
            SqlCommand ca = new SqlCommand("select SUM(prix_total) from Sont_present,Commande,Client where Sont_present.commande_numero = Commande.commande_numero and Commande.client_reference = Client.client_reference and client_categorie = @categorie", _connect);
            ca.Parameters.AddWithValue("@categorie", i);
            int a = (int)ca.ExecuteScalar();
            _connect.Close();
            return a;
        }
    }
}
