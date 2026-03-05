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
    public partial class FormTarifLiasonPeriode : Form
    {
        public FormTarifLiasonPeriode()
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
                    lbxSecteurs.Items.Add(secteur);
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
                Periode periode;
                string datedebut; string datefin;

                maCnx2.Open();
                string requete = "select * from periode";
                var maCde = new MySqlCommand(requete, maCnx2);
                jeuEnr2 = maCde.ExecuteReader();
                while (jeuEnr2.Read())
                {
                    datedebut = jeuEnr2["datedebut"].ToString();
                    datefin = jeuEnr2["datefin"].ToString();
                    periode = new Periode((short)jeuEnr2["noperiode"], datedebut,datefin);
                    cmbPeriode.Items.Add(periode);
                }
                maCnx2.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Label label = new Label();
            TextBox textBox;
            Type type;
            int i = 2;
            string lettrecategorie;
            short notype;
            string libelle;
            label.Text = "Categorie-type";
            label.Location = new Point(50, 30);
            gbxcategorie.Controls.Add(label);
            label = new Label();
            label.Text = "Tarif";
            label.Location = new Point(250, 30);
            gbxcategorie.Controls.Add(label);
            try
            {
                MySqlConnection maCnx3;
                MySqlDataReader jeuEnr3 = null;
                maCnx3 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                Periode periode;
                maCnx3.Open();
                string requete = "select * from type";
                var maCde = new MySqlCommand(requete, maCnx3);
                jeuEnr3 = maCde.ExecuteReader();
                while (jeuEnr3.Read())
                {
                    lettrecategorie = (string)jeuEnr3["lettrecategorie"];
                    notype = (short)jeuEnr3["notype"];
                    libelle = (string)jeuEnr3["libelle"];
                    type = new Type(lettrecategorie, notype, libelle );
                    label = new Label();
                    label.Text = type.ToString();
                    label.Location = new Point(50, i * 30);
                    gbxcategorie.Controls.Add((label));
                    textBox = new TextBox();
                    textBox.Location = new Point(250, i * 30);
                    textBox.Tag = type.getlettre()+";"+ type.getnotype();
                    gbxcategorie.Controls.Add(textBox);
                    i += 1;
                }
                maCnx3.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection maCnx1;
                MySqlDataReader jeuEnr1 = null;
                maCnx1 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx1.Open();
                Liaison liaison;
                string texteLiaison;
                string requete1 = "select NOLIAISON, NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE,pd.nom as pd , pa.nom as pa from liaison l inner join port pd on (l.NOPORT_DEPART = pd.NOPORT) inner join port pa on (l.NOPORT_ARRIVEE = pa.NOPORT) where nosecteur = @nosecteur";
                var maCde1 = new MySqlCommand(requete1, maCnx1);
                maCde1.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteurs.SelectedItem).getidSecteur());
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

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx.Open();
                string requete = "insert into tarifer (noperiode, lettrecategorie, notype,noliaison,tarif) values (@noperiode, @lettrecategorie, @notype,@noliaison,@tarif)";
                string lettrecategorie;
                short notype;
                foreach (object control in gbxcategorie.Controls) {
                    short noperiode = (short)((Periode)cmbPeriode.SelectedItem).getnoperiode();
                    int noliaison = ((Liaison)cmbLiaison.SelectedItem).getNoLiaison();
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        string lettrecategorieNotype = textBox.Tag.ToString();
                        string[] tablettrecategorieNotype = lettrecategorieNotype.Split(';');
                        lettrecategorie = tablettrecategorieNotype[0];
                        notype = short.Parse(tablettrecategorieNotype[1]);
                        double tarif = Double.Parse(textBox.Text);
                        var maCde = new MySqlCommand(requete, maCnx);
                        maCde.Parameters.AddWithValue("@noperiode", noperiode);
                        maCde.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);
                        maCde.Parameters.AddWithValue("@notype",notype);
                        maCde.Parameters.AddWithValue("@noliaison", noliaison);
                        maCde.Parameters.AddWithValue("@tarif", tarif);
                        maCde.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("tarif ajouté", "tout les tarifs ont été ajouté", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
