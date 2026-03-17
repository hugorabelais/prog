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
    public partial class FormAjouterLiaison : Form
    {
        public FormAjouterLiaison()
        {
            InitializeComponent();
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                
                    Secteur secteur;
                    maCnx.Open();
                    string requete = "select * from secteur";
                    var maCde = new MySqlCommand(requete, maCnx);
                    jeuEnr = maCde.ExecuteReader();
                    while (jeuEnr.Read())
                    {
                        secteur = new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]);
                        lbxSecteur.Items.Add(secteur);
                    }
                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                MySqlConnection maCnx2;
                MySqlDataReader jeuEnr2 = null;

                maCnx2 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                
                    Port port;
                    maCnx2.Open();
                    string requete2 = "select * from port";
                    var maCde2 = new MySqlCommand(requete2, maCnx2);
                    jeuEnr2 = maCde2.ExecuteReader();

                    while (jeuEnr2.Read())
                    {
                        port = new Port((int)jeuEnr2["noport"], (string)jeuEnr2["nom"]);
                        cmbPortDepart.Items.Add(port);
                        cmbPortArrivee.Items.Add(port);
                    }
                maCnx2.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPortDepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterLiaison_Click(object sender, EventArgs e)
        {
            if (lbxSecteur.SelectedItem != null && cmbPortArrivee.SelectedItem != null && cmbPortDepart.SelectedItem != null && tbxDistance.Text != "")
            {
                try
                {
                    MySqlConnection maCnx;
                    MySqlDataReader jeuEnr = null;
                    maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                    maCnx.Open();
                    double distance = double.Parse(tbxDistance.Text);
                    string requete = "insert into liaison (noport_depart, nosecteur, noport_arrivee,distance) values (@noport_depart, @nosecteur, @noport_arrivee,@distance)";
                    var maCde = new MySqlCommand(requete, maCnx);
                    maCde.Parameters.AddWithValue("@noport_depart", ((Port)cmbPortDepart.SelectedItem).getidPort());
                    maCde.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteur.SelectedItem).getidSecteur());
                    maCde.Parameters.AddWithValue("@noport_arrivee", ((Port)cmbPortArrivee.SelectedItem).getidPort());
                    maCde.Parameters.AddWithValue("@distance", distance);
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("liaison ajouté", "liaison ajouté", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    maCnx.Close();
                }
                catch (MySqlException er)
                {

                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner toutes les informations !");
            }




        }

        private void tbxDistance_Validating(object sender, CancelEventArgs e)
        {
            var objetRegEx = new Regex("^[0-9]*([,][0-9])*$");
            // Nombre : ^[0-9]*$
            // Alphabétique (sans accent, sans blanc : ^[a-zA-Z]*$
            // Alphabétique (avec accent) : ^[a-zA-Zéèêëçàâôù ûïî]*$
            var résultatTest = objetRegEx.Match(tbxDistance.Text);
            if (!résultatTest.Success)
            {
                // KO : Fond de la zone de saisie passe en rouge
                tbxDistance.BackColor = Color.Red;
                e.Cancel = true;
            }

            else
            {
                // OK : Fond de la zone de saisie passe en vert
                tbxDistance.BackColor = Color.Green;
            }
        }
    }
}
