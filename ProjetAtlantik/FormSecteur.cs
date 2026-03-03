using MySql.Data.MySqlClient;
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
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            using (maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password="))
            {
                string nom = tbxAjouterSecteur.Text;
                try
                {
                    maCnx.Open(); // on se connecte
                    string requete = "insert into secteur (nom) values (@nom)";
                    var maCde = new MySqlCommand(requete, maCnx);
                    maCde.Parameters.AddWithValue("@nom", nom);
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("secteur ajouté", "secteur ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (MySqlException er)
                {
                    Console.WriteLine("Erreur " + er.ToString());
                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           Console.ReadLine();
        }
    }
}
