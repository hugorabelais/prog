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
namespace ProjetAtlantik
{
    public partial class FormSecteur : Form
    {
        public FormSecteur()
        {
            InitializeComponent();
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            NpgsqlConnection maCnx;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=root;Database=Atlantik;");
            string nom = tbxAjouterSecteur.Text;
            try
            {
                maCnx.Open(); // on se connecte
                string requete = "insert into secteur (nom) values (@nom)";
                var maCde = new NpgsqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();
                MessageBox.Show("secteur ajouté", "secteur ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (NpgsqlException er)
            {
                Console.WriteLine("Erreur " + er.ToString());
                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
           Console.ReadLine();
        }
    }
}
