using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BDD
{
    public class produit
    {

        SqlConnection _connect;
        public produit(string chaine)
        {
            _connect = new SqlConnection(chaine);
        }
        public void Ajouterproduits(Produits prod)
        {
            _connect.Open();
            SqlCommand ajouter = new SqlCommand("insert into produits (produit_nom,produit_libelle_court,produit_libelle_long,produit_rubrique,produit_stock,produit_photo,prix_achat_initial,prix_vente,taux_tva) values (@nom,@libcourt,@liblong,@rubrique,@stock,@photo,@prixini,@prixvente,@tva)", _connect);
            ajouter.Parameters.AddWithValue("@nom", prod.produit_nom);
            ajouter.Parameters.AddWithValue("@libcourt", prod.produit_libelle_court);
            ajouter.Parameters.AddWithValue("@liblong", prod.produit_libelle_long);
            ajouter.Parameters.AddWithValue("@rubrique", prod.produit_rubrique);
            ajouter.Parameters.AddWithValue("@stock", prod.produit_stock);
            ajouter.Parameters.AddWithValue("@photo", prod.produit_photo);
            ajouter.Parameters.AddWithValue("@prixini", prod.prix_achat_initial);
            ajouter.Parameters.AddWithValue("@prixvente", prod.prix_vente);
            ajouter.Parameters.AddWithValue("@tva", prod.taux_tva);

            ajouter.ExecuteNonQuery();

            SqlCommand select = new SqlCommand("select max(produit_reference)from produits", _connect);
            int id = (int)select.ExecuteScalar();

            _connect.Close();

        }
        public List<Produits> Rechercherproduit(string i)
        {
            _connect.Open();

            List<Produits> produit = new List<Produits>();
            SqlCommand requete = new SqlCommand("select * from produits where produit_rubrique=@rubrique", _connect);
            requete.Parameters.AddWithValue("@rubrique", i);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Produits prod = new Produits();

                prod.produit_reference = (int)lecture["produit_reference"];
                prod.produit_nom = lecture["produit_nom"].ToString();
                prod.prix_vente = (decimal)lecture["prix_vente"];
                prod.produit_stock = (int)lecture["produit_stock"];                                
                produit.Add(prod);
            }
            lecture.Close();
            _connect.Close();
            return produit;
        }
        public Produits Afficher_produit(int i)
        {
            _connect.Open();
            SqlCommand affiche = new SqlCommand("select * from produits where produit_reference=@Id", _connect);
            affiche.Parameters.AddWithValue("@Id", i);
            SqlDataReader _affiche = affiche.ExecuteReader();
            Produits c = new Produits();

            if (_affiche.Read())
            {
                c.produit_reference = Convert.ToInt32(_affiche["produit_reference"]);
                c.produit_nom = _affiche["produit_nom"].ToString();
                c.produit_libelle_court = _affiche["produit_libelle_court"].ToString();
                c.produit_libelle_long = _affiche["produit_libelle_long"].ToString();
                c.produit_rubrique = _affiche["produit_rubrique"].ToString();
                c.produit_stock = Convert.ToInt32(_affiche["produit_stock"]);
                c.produit_photo = _affiche["produit_photo"].ToString();
                c.prix_achat_initial = Convert.ToInt32(_affiche["prix_achat_initial"]);
                c.prix_vente = Convert.ToInt32(_affiche["prix_vente"]);
                c.taux_tva = Convert.ToInt32(_affiche["taux_tva"]);

            }
            _affiche.Close();
            _connect.Close();
            return c;
        }
        public List<Produits> Rechercherproduitid(int i)
        {
            _connect.Open();

            List<Produits> produit = new List<Produits>();
            SqlCommand requete = new SqlCommand("select * from produits where produit_reference=@reference", _connect);
            requete.Parameters.AddWithValue("@reference", i);
            SqlDataReader lecture = requete.ExecuteReader();
            while (lecture.Read())
            {
                Produits prod = new Produits();

                prod.produit_reference = (int)lecture["produit_reference"];
                prod.produit_nom = lecture["produit_nom"].ToString();
                prod.prix_vente = (decimal)lecture["prix_vente"];
                prod.produit_stock = (int)lecture["produit_stock"];
                prod.produit_libelle_court = lecture["produit_libelle_court"].ToString();
                prod.taux_tva = (double)lecture["taux_tva"];
                
                produit.Add(prod);
            }
            lecture.Close();
            _connect.Close();
            return produit;
        }
    }
}
