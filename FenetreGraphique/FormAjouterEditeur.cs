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
using System.Xml.Linq;
using Npgsql;
namespace FenetreGraphique
{
    public partial class FormAjouterEditeur : Form
    {
        public FormAjouterEditeur()
        {
            InitializeComponent();
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            string name = tbxNom.Text;
            string adress = tbxAdresse.Text;
            string city = tbxVille.Text;
            string zip = tbxZIP.Text;
            try
            {
                string requête;
                maCnx.Open(); // on se connecte
                              // DEBUT requête paramétrée
                requête = "Insert into publishers(name,address,city,zip) values (@name,@adress,@city,@zip) RETURNING pubid";
                var maCde = new NpgsqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@name", name);
                maCde.Parameters.AddWithValue("@adress", adress);
                maCde.Parameters.AddWithValue("@city", city);
                maCde.Parameters.AddWithValue("@zip", zip);
                int idAuthorGenere;
                idAuthorGenere = (int)(maCde.ExecuteScalar());
                MessageBox.Show("id editeur : "+ idAuthorGenere, "editeur ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (NpgsqlException er)
            {
                Console.WriteLine("Erreur " + er.ToString());
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
