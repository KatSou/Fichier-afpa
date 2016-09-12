using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDD
{
    public class Client_fr
    {
        SqlConnection _connect;


        public Client_fr (string chaine)
        {
            _connect = new SqlConnection(chaine);
            
        }

        public void Ajouterclient (Client cli,Adresse add)
        {
            _connect.Open();
            SqlCommand ajout = new SqlCommand("insert into client (client_categorie,client_nom,client_prenom,client_telephone,client_mail,type_reglement,prix_coef,pro_siret,pro_raison) values (@categorie,@nom,@prenom,@telephone,@mail,@reglement,@coef,@siret,@raison)", _connect);
            ajout.Parameters.AddWithValue("@categorie", cli.client_categorie);
            ajout.Parameters.AddWithValue("@nom", cli.client_nom);
            ajout.Parameters.AddWithValue("@prenom", cli.client_prenom);
            ajout.Parameters.AddWithValue("@telephone", cli.client_telephone);
            ajout.Parameters.AddWithValue("@mail", cli.client_mail);
            ajout.Parameters.AddWithValue("@reglement", cli.type_reglement);
            ajout.Parameters.AddWithValue("@coef", cli.prix_coef);
            ajout.Parameters.AddWithValue("@siret", cli.pro_siret);
            ajout.Parameters.AddWithValue("@raison", cli.pro_raison);
            ajout.ExecuteNonQuery();

            SqlCommand select = new SqlCommand("select max(client_reference)from client", _connect);
            int id = (int) select.ExecuteScalar();


            SqlCommand adresse = new SqlCommand("insert into adresse (client_reference,client_adresse,client_code_postal,client_ville,client_facturation_adresse,client_facturation_code_postal,client_facturation_ville,client_livraison_adresse,client_livraison_code_postal,client_livraison_ville) values (@id,@cladd,@clcp,@clville,@facadd,@faccp,@facville,@livadd,@livcp,@livville)",_connect);
            adresse.Parameters.AddWithValue("@id", id);
            adresse.Parameters.AddWithValue("@cladd", add.client_adresse);
            adresse.Parameters.AddWithValue("@clcp", add.client_code_postal);
            adresse.Parameters.AddWithValue("@clville", add.client_ville);
            adresse.Parameters.AddWithValue("@facadd", add.client_facturation_adresse);
            adresse.Parameters.AddWithValue("@faccp", add.client_facturation_code_postal);
            adresse.Parameters.AddWithValue("@facville", add.client_facturation_ville);
            adresse.Parameters.AddWithValue("@livadd", add.client_livraison_adresse);
            adresse.Parameters.AddWithValue("@livcp", add.client_livraison_code_postal);
            adresse.Parameters.AddWithValue("@livville", add.client_livraison_ville);
            adresse.ExecuteNonQuery();

            _connect.Close();

        }
        public List<string> Rechercherclient (string i)
        {
            _connect.Open();

            List<string> client = new List<string>();
            SqlCommand requete = new SqlCommand("select client_reference,client_nom,client_prenom,client_mail from client where client_nom='"+i+"'", _connect);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                string a = lecture["client_reference"].ToString()+" "+ lecture["client_nom"].ToString() + " " + lecture["client_prenom"].ToString() + " " + lecture["client_mail"].ToString();
                client.Add(a);
            }
            lecture.Close();
            _connect.Close();
            return client;
        }
        public Client Afficher(string i)
        {
            _connect.Open();
            SqlCommand affiche = new SqlCommand("select * from client where client_reference=@Id", _connect);
            affiche.Parameters.AddWithValue("@Id", i);
            SqlDataReader _affiche = affiche.ExecuteReader();
            Client c = new Client();

            if (_affiche.Read())
            {                
                c.client_nom = _affiche["client_nom"].ToString();
                c.client_prenom = _affiche["client_prenom"].ToString();
                c.client_mail = _affiche["client_mail"].ToString();
                c.client_telephone = _affiche["client_telephone"].ToString();
                c.prix_coef = Convert.ToDouble(_affiche["prix_coef"]);
                c.pro_siret = _affiche["pro_siret"].ToString();
                c.pro_raison = _affiche["pro_raison"].ToString();
                c.client_categorie = _affiche["client_reference"].ToString();
                c.client_reference = Convert.ToInt32(_affiche["client_reference"]);
                
            }
            _affiche.Close();
            _connect.Close();
            return c;
        }

        public Adresse Afficheradd(string i)
        {
            _connect.Open();
            SqlCommand affiche = new SqlCommand("select * from adresse where client_reference=@Id", _connect);
            affiche.Parameters.AddWithValue("@Id", i);
            SqlDataReader _affiche = affiche.ExecuteReader();
            Adresse c = new Adresse();

            if (_affiche.Read())
            {
                c.client_adresse = _affiche["client_adresse"].ToString();
                c.client_ville = _affiche["client_ville"].ToString();
                c.client_code_postal = _affiche["client_code_postal"].ToString();
                c.client_facturation_adresse = _affiche["client_facturation_adresse"].ToString();
                c.client_facturation_code_postal = _affiche["client_facturation_code_postal"].ToString();
                c.client_facturation_ville = _affiche["client_facturation_ville"].ToString();
                c.client_livraison_adresse = _affiche["client_livraison_adresse"].ToString();
                c.client_livraison_code_postal = _affiche["client_livraison_code_postal"].ToString();
                c.client_livraison_ville = _affiche["client_livraison_ville"].ToString();

            }
            _affiche.Close();
            _connect.Close();
            return c;
        }
        public void Modifier (Client cli, string i)
        {
            _connect.Open();
            SqlCommand modifier = new SqlCommand("update client set client_categorie = @categorie, client_nom=@nom, client_prenom=@prenom,client_telephone=@telephone,client_mail=@mail,type_reglement=@reglement,prix_coef=@coef,pro_siret=@siret,pro_raison=@raison", _connect);
            modifier.Parameters.AddWithValue("@categorie", cli.client_categorie);
            modifier.Parameters.AddWithValue("@nom", cli.client_nom);
            modifier.Parameters.AddWithValue("@prenom", cli.client_prenom);
            modifier.Parameters.AddWithValue("@telephone", cli.client_telephone);
            modifier.Parameters.AddWithValue("@mail", cli.client_mail);
            modifier.Parameters.AddWithValue("@reglement", cli.type_reglement);
            modifier.Parameters.AddWithValue("@coef", cli.prix_coef);
            modifier.Parameters.AddWithValue("@siret", cli.pro_siret);
            modifier.Parameters.AddWithValue("@raison", cli.pro_siret);
            modifier.ExecuteNonQuery();

           // SqlCommand modif = new SqlCommand("update adresse")
        }
    }
}
