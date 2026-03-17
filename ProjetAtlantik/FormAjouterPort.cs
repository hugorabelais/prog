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

namespace ProjetAtlantik
{
    public partial class FormAjouterPort : Form
    {
        public FormAjouterPort()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            using (maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password="))
            {
                string nom = tbxAjouterPort.Text;
                try
                {
                    maCnx.Open(); // on se connecte
                    string requete = "insert into port (nom) values (@nom)";
                    var maCde = new MySqlCommand(requete, maCnx);
                    maCde.Parameters.AddWithValue("@nom", nom);
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("port ajouté", "port ajouté", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (MySqlException er)
                {
                    Console.WriteLine("Erreur " + er.ToString());
                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Console.ReadLine();
        }

        private void tbxAjouterPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAjouterPort_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$
            var résultatTest = objetRegEx.Match(tbxAjouterPort.Text);
            if (!résultatTest.Success)
            {
                // KO : Fond de la zone de saisie passe en rouge
                tbxAjouterPort.BackColor = Color.Red;
                e.Cancel = true;
            }

            else
            {
                // OK : Fond de la zone de saisie passe en vert
                tbxAjouterPort.BackColor = Color.Green;
            }
        }
    }
}
