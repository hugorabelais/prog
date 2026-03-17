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

namespace ProjetAtlantik
{
    public partial class FormAjouterTraverse : Form
    {
        public FormAjouterTraverse()
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
                MySqlConnection maCnx1;
                MySqlDataReader jeuEnr1 = null;
                maCnx1 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx1.Open();
                Bateau bateau;
                string requete1 = "select * from bateau";
                var maCde1 = new MySqlCommand(requete1, maCnx1);
                jeuEnr1 = maCde1.ExecuteReader();

                while (jeuEnr1.Read())
                {
                    int nobateau = (int)jeuEnr1["nobateau"];
                    bateau = new Bateau(nobateau, (string)jeuEnr1["nom"]);
                    cbxNomBateau.Items.Add(bateau);

                }

                maCnx1.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection maCnx1;
                MySqlDataReader jeuEnr1 = null;
                maCnx1 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx1.Open();
                Liaison liaison;
                string requete1 = "select NOLIAISON, NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE,pd.nom as pd , pa.nom as pa from liaison l inner join port pd on (l.NOPORT_DEPART = pd.NOPORT) inner join port pa on (l.NOPORT_ARRIVEE = pa.NOPORT) where nosecteur = @nosecteur";
                var maCde1 = new MySqlCommand(requete1, maCnx1);
                maCde1.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteur.SelectedItem).getidSecteur());
                jeuEnr1 = maCde1.ExecuteReader();

                while (jeuEnr1.Read())
                {
                    liaison = new Liaison((int)jeuEnr1["noliaison"], (int)jeuEnr1["noport_depart"], (int)jeuEnr1["nosecteur"], (int)jeuEnr1["noport_arrivee"], (double)jeuEnr1["distance"], (string)jeuEnr1["pd"], (string)jeuEnr1["pa"]);
                    cmbLiaison.Items.Add(liaison);

                }

                maCnx1.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx.Open();
                string requete = "insert into traversee (noliaison, nobateau, dateheuredepart,dateheurearrivee ,clotureembarquement) values (@noliaison, @nobateau, @dateheuredepart,@dateheurearrivee,@clotureembarquement)";
                short clotureEmbarquement = 0;
                DateTime dateHeureDepart = DateTime.Parse(dateDepart.Text + " " + heureDepart.Text);
                DateTime dateHeureArrive = DateTime.Parse(dateArrive.Text +" "+ heureArrive.Text);
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).getNoLiaison());
                maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cbxNomBateau.SelectedItem).getnobateau());
                maCde.Parameters.AddWithValue("@dateheuredepart", dateHeureDepart);
                maCde.Parameters.AddWithValue("@dateheurearrivee", dateHeureArrive);
                maCde.Parameters.AddWithValue("@clotureembarquement", clotureEmbarquement);
                maCde.ExecuteNonQuery();
                MessageBox.Show("traversée ajoutée", "la traversée a été ajouté", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
