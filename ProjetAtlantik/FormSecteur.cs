using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void FormSecteur_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void tbxAjouterSecteur_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$
            var résultatTest = objetRegEx.Match(tbxAjouterSecteur.Text);
            if (!résultatTest.Success)
            {
                // KO : Fond de la zone de saisie passe en rouge
                tbxAjouterSecteur.BackColor = Color.Red;
                e.Cancel = true;
            }

            else
            {
                // OK : Fond de la zone de saisie passe en vert
                tbxAjouterSecteur.BackColor = Color.Green;
            }
        }
    }
}
