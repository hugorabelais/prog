using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace FenetreGraphique
{
    public partial class FormAjouterLivre : Form
    {
        public FormAjouterLivre()
        {
            InitializeComponent();
            NpgsqlConnection maCnx;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            Publisher publisher;
            maCnx.Open();
            string requete = "select pubid,name from publishers";
            var maCde = new NpgsqlCommand(requete, maCnx);
            jeuEnr = maCde.ExecuteReader();
            while (jeuEnr.Read())
            {
                publisher = new Publisher((int)jeuEnr["pubid"], (string)jeuEnr["name"]);
                cmbPublisher.Items.Add(publisher.ToString());
            }
            maCnx.Close();
            NpgsqlConnection maCnx2;
            NpgsqlDataReader jeuEnr2 = null;
            maCnx2 = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            Auteur auteur;
            maCnx2.Open();
            string requete2 = "select au_id,author from authors";
            var maCde2 = new NpgsqlCommand(requete2, maCnx2);
            jeuEnr2 = maCde2.ExecuteReader();
            while (jeuEnr2.Read())
            {
                auteur = new Auteur((int)jeuEnr2["au_id"], (string)jeuEnr2["author"]);
                lbxAuteur.Items.Add(auteur.ToString());
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {   
            string titre = tbxTitre.Text;
            string ISBN = tbxISBN.Text;
            int pubid = ((Publisher)(cmbPublisher.SelectedItem)).Getpuid();
            int 

            




            try
            {
                string requête1; string requête2;
                maCnx.Open(); // on se connecte
                              // DEBUT requête paramétrée
                requête1 = "insert into titles(title,isbn,pubid) values (@title, @ISBN, @puid); insert into titleauthor(isbn,au_id) values (@ISBN , @idauteur)";
                var maCde = new NpgsqlCommand(requête1, maCnx);
                maCde.Parameters.AddWithValue("@title", titre);
                maCde.Parameters.AddWithValue("@ISBN", ISBN);
                maCde.Parameters.AddWithValue("@puid", puid);
                maCde.Parameters.AddWithValue("@ISBN", ISBN);
                maCde.Parameters.AddWithValue("@idauteur", idauteur);
                maCde.ExecuteNonQuery();

            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Erreur " + e.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }
    }
}
