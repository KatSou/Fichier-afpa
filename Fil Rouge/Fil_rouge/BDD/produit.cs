﻿using System;
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
            ajouter.Parameters.AddWithValue("@nom",prod.produit_nom);
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
    }
}