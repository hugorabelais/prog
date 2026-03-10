using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormAfficherLiaison : Form
    {
        public int getQuantiteEnregistree(int noTraversee, string lettreCategorie)
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");

                int somme = 0;
                maCnx.Open();
                string requete = "select QUANTITERESERVEE from traversee t inner join reservation r on (t.NOTRAVERSEE = r.NOTRAVERSEE) inner join enregistrer e on (e.NORESERVATION = r.NORESERVATION) where t.NOTRAVERSEE = @noTraversee and e.LETTRECATEGORIE= @lettrecategorie";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@notraversee", noTraversee);
                maCde.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    somme += (int)jeuEnr["quantitereservee"];
                }
                maCnx.Close();
                return somme;
            }
            catch (MySqlException er)
            {

                return -1;
            }
            
        }

        public int getCapciteMaximale(int noTraversee, string lettreCategorie)
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");

                int capacite;
                maCnx.Open();
                string requete = "select CAPACITEMAX from contenir c inner join bateau b on (b.NOBATEAU = c.NOBATEAU) inner join traversee t on (t.NOBATEAU =c.NOBATEAU) where c.LETTRECATEGORIE = @lettrecategorie and t.NOTRAVERSEE = @notraversee }";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@notraversee", noTraversee);
                maCde.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                jeuEnr = maCde.ExecuteReader();
                capacite = (int)jeuEnr["capacitemax"];

                maCnx.Close();
                return capacite;
            }
            catch (MySqlException er)
            {

                return -1;
            }
        }

        public List<Object> getLesCategories()
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                Categorie categorie;
                List <Object> tabCategorie = new List<Object>();
                maCnx.Open();
                string requete = "SELECT * FROM categorie";
                var maCde = new MySqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    string lettrecategorie = (string)jeuEnr["lettrecategorie"];
                    categorie = new Categorie(lettrecategorie, (string)jeuEnr["libelle"]);
                    tabCategorie.Add(categorie);
                }

                maCnx.Close();
                return tabCategorie;
            }
            catch (MySqlException er)
            {
                List<Object> tabCategorie = new List<Object>();
                return tabCategorie;
            }
        }

        public List<Object> getLesTraverseesBateaux(int noLiaison, string dateTraversee)
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                Traversee traversee;
                List<Object> tabTraversee = new List<Object>();
                dateTraversee += "%";
                maCnx.Open();
                string requete = "SELECT NOTRAVERSEE, DATE_FORMAT(DATEHEUREDEPART, '%H:%i') , nom  from traversee t inner join bateau b on (t.NOBATEAU = b.NOBATEAU) where NOLIAISON = @noliaison and DATEHEUREDEPART like @dateTraversee";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noliaison", noLiaison);
                maCde.Parameters.AddWithValue("@dateTraversee", dateTraversee);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    string date = (string)(jeuEnr["DATE_FORMAT(DATEHEUREDEPART, '%H:%i')"]);
                    traversee = new Traversee((int)jeuEnr["notraversee"], date, (string)jeuEnr["nom"]);
                    tabTraversee.Add(traversee);
                }

                maCnx.Close();
                return tabTraversee;
            }
            catch (MySqlException er)
            {
                List<Object> tabtraversee = new List<Object>();
                return tabtraversee;
            }
        }


        public FormAfficherLiaison()
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

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            Liaison liaison = (Liaison)cmbLiaison.SelectedItem;
            string date = dateSelectioner.Text;
            List<object> tabcategorie = getLesCategories();
            List<object> tabTraversee = getLesTraverseesBateaux(liaison.getNoLiaison(), date);
            lvAfficherTraverser.Items.Clear();
            lvAfficherTraverser.Columns.Clear();
            lvAfficherTraverser.View = View.Details;
            lvAfficherTraverser.GridLines = true;
            lvAfficherTraverser.FullRowSelect = true;
            lvAfficherTraverser.Columns.Add("N°", 100); // 100 = largeur colonne
            lvAfficherTraverser.Columns.Add("Heure", 70);
            lvAfficherTraverser.Columns.Add("Bateau", 90);
            foreach (Categorie categorie in tabcategorie)
            {

                lvAfficherTraverser.Columns.Add(categorie.getlettrecategorie() +" "+ categorie.getlibelle(), 80);

            }

            foreach (Traversee traversee in tabTraversee)
            {

                var tabItem = new string[6];
                tabItem[0] = traversee.getnoTraversee().ToString();
                tabItem[1] = traversee.getTime();
                tabItem[2] = traversee.getNom();
                tabItem[3] = getCapciteMaximale(traversee.getnoTraversee() , "A").ToString();
                tabItem[4] = getCapciteMaximale(traversee.getnoTraversee(), "B").ToString(); 
                tabItem[5] = getCapciteMaximale(traversee.getnoTraversee(), "C").ToString();



                lvAfficherTraverser.Items.Add(new ListViewItem(tabItem));

            }






        }
    }
}
