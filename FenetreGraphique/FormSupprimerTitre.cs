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
    public partial class FormSupprimerTitre : Form
    {
        public FormSupprimerTitre()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            string ISBN = tbxISBN.Text;
            try
            {
                string requête1; string requête2;
                maCnx.Open(); // on se connecte
                              // DEBUT requête paramétrée
                requête1 = "DELETE FROM titles WHERE isbn = @ISBN";
                requête2 = "DELETE FROM titleauthor WHERE isbn = @ISBN";
                var maCde = new NpgsqlCommand(requête1, maCnx);
                maCde.Parameters.AddWithValue("@ISBN", ISBN);
                var maCde2 = new NpgsqlCommand(requête2, maCnx);
                maCde2.Parameters.AddWithValue("@ISBN", ISBN);
                maCde2.ExecuteNonQuery();
                maCde.ExecuteNonQuery();
                MessageBox.Show("titre supprimer", "suppresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
