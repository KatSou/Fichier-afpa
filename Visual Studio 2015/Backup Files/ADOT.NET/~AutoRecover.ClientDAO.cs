using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{

    public class ClientDAO
    {
       
        SqlConnection _connect;
        public ClientDAO(string chaine)
        {
            _connect = new SqlConnection(chaine);
            _connect.Open();
        }
        public void Ajouter (Client cli)
        {
            SqlCommand requete = new SqlCommand("insert into client(cli_nom, cli_prenom, cli_ville) values(@nom, @prenom,@ville)", _connect);
            requete.Parameters.AddWithValue("@nom", cli.Nom);
            requete.Parameters.AddWithValue("@prenom",cli.Prenom);
            requete.Parameters.AddWithValue("@ville",cli.Ville);
            requete.ExecuteNonQuery();
            SqlCommand requete2 = new SqlCommand("select max(id)from client", _connect);            
            

        }
        public void Modifier (Client cli, string i)
        {
            SqlCommand requete = new SqlCommand("update client set cli_nom = @nom, cli_prenom = @prenom, cli_ville = @ville where cli_id=@id", _connect);
            requete.Parameters.AddWithValue("@id", i);
            requete.Parameters.AddWithValue("@nom", cli.Nom);
            requete.Parameters.AddWithValue("@prenom", cli.Prenom);
            requete.Parameters.AddWithValue("@ville", cli.Ville);
            requete.ExecuteNonQuery();
        }
        public void Supprimer (Client cli, string i)
        {
            SqlCommand requete = new SqlCommand("delete  from client where cli_id=@id", _connect);
            requete.Parameters.AddWithValue("@id", i);
            requete.ExecuteNonQuery();
        }
        public Client Afficher (string i)
        {
            SqlCommand affiche = new SqlCommand("select * from client where cli_id=@Id", _connect);
            affiche.Parameters.AddWithValue("@Id", i);
            SqlDataReader _affiche = affiche.ExecuteReader();
            Client c = new Client();

            if (_affiche.Read())
            {
                
                
                c.Nom =_affiche["cli_nom"].ToString();
                c.Prenom = _affiche["cli_prenom"].ToString();
                c.Ville = _affiche["cli_ville"].ToString();
                
            }
            _affiche.Close();
            return c;
        }
    
        public List<Client> List()
        {          
            List<Client> resultat= new List<Client>();
            SqlCommand requete = new SqlCommand("select * from client", _connect);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Client c = new Client();
                c.Id = Convert.ToInt32(lecture["cli_id"]);
                c.Nom = Convert.ToString(lecture["cli_nom"]);
                c.Prenom = Convert.ToString(lecture["cli_prenom"]);
                c.Ville = Convert.ToString(lecture["cli_ville"]);
                resultat.Add(c);
            }
            lecture.Close();
            return resultat;
        }
    }
}
