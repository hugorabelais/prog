using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class FormAfficherReservation : Form
    {
        public string getLiaison(int notraversee)
        {
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                string nomDepart;
                string nomArrivee;
                maCnx.Open();
                string requete = "select pd.NOM as PD, pa.NOM as PA from traversee t inner join liaison l on (t.NOLIAISON = l.NOLIAISON) inner join port pd on (pd.NOPORT = l.NOPORT_DEPART) inner join port pa on (pa.NOPORT = l.NOPORT_ARRIVEE) where NOTRAVERSEE = @notraversee";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@notraversee", notraversee);
                jeuEnr = maCde.ExecuteReader();
                jeuEnr.Read();
                nomDepart =(string)jeuEnr["PD"];
                nomArrivee = (string)jeuEnr["PA"];
                maCnx.Close();
                return nomDepart + " - " + nomArrivee;
            }
            catch (MySqlException er)
            {

                return "ccccccc";
            }
        }

        public FormAfficherReservation()
        {
            InitializeComponent();
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");

                Client client;
                maCnx.Open();
                string requete = "select * from client";
                var maCde = new MySqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    client = new Client((int)jeuEnr["noclient"], (string)jeuEnr["nom"], (string)jeuEnr["prenom"]);
                    cbxNomPrenom.Items.Add(client);
                }
                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxNomPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {

            lvAfficherReservation.Items.Clear();
            lvAfficherReservation.Columns.Clear();
            lvAfficherReservation.View = View.Details;
            lvAfficherReservation.GridLines = true;
            lvAfficherReservation.FullRowSelect = true;
            lvAfficherReservation.Columns.Add("N° reservation", 90); 
            lvAfficherReservation.Columns.Add("Liaison", 120);
            lvAfficherReservation.Columns.Add("n°Traversée", 60);
            lvAfficherReservation.Columns.Add("Date départ", 120);
            var tabItem = new string[6];
            Client client = (Client)cbxNomPrenom.SelectedItem;
            int noclient = client.getNoClient();
            try
            {
                MySqlConnection maCnx;
                MySqlDataReader jeuEnr = null;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx.Open();
                string requete = "select * from client c inner join reservation r on (c.noclient = r.noclient) where c.noclient = @noclient; ";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noclient", noclient);
                jeuEnr = maCde.ExecuteReader();
                
                while (jeuEnr.Read())
                {

                    tabItem[0] = ((int)jeuEnr["noreservation"]).ToString();
                    tabItem[1] = getLiaison((int)jeuEnr["notraversee"]);
                    tabItem[2] = ((int)jeuEnr["notraversee"]).ToString();
                    tabItem[3] = ((DateTime)jeuEnr["dateheure"]).ToString();
                    lvAfficherReservation.Items.Add(new ListViewItem(tabItem));

                }
                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvAfficherReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbxReservation.Controls.Clear();
            if (lvAfficherReservation.SelectedItems.Count != 0)
            {
                Label label = new Label();

                int i = 2;
                int noreservation = int.Parse(lvAfficherReservation.SelectedItems[0].Text);
                int quantitereservee;
                string libelle;
                try
                {
                    MySqlConnection maCnx3;
                    MySqlDataReader jeuEnr3 = null;
                    maCnx3 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                    maCnx3.Open();
                    string requete = "SELECT libelle,QUANTITERESERVEE, MONTANTTOTAL, MODEREGLEMENT FROM enregistrer e inner join reservation r on (e.NORESERVATION = r.NORESERVATION) inner join type t on (t.LETTRECATEGORIE = e.LETTRECATEGORIE and t.NOTYPE = e.NOTYPE) where r.NORESERVATION = @noreservation;";
                    var maCde = new MySqlCommand(requete, maCnx3);
                    maCde.Parameters.AddWithValue("@noreservation", noreservation);
                    jeuEnr3 = maCde.ExecuteReader();
                    while (jeuEnr3.Read())
                    {
                        libelle = (string)jeuEnr3["libelle"];
                        quantitereservee = (int)jeuEnr3["quantitereservee"];
                        label = new Label();
                        label.Text = libelle.ToString();
                        label.Location = new Point(50, i * 30);
                        gbxReservation.Controls.Add((label));
                        label = new Label();
                        label.Text = quantitereservee.ToString();
                        label.Location = new Point(175, i * 30);
                        gbxReservation.Controls.Add(label);
                        i += 1;
                    }
                    label = new Label();
                    label.Text = "Montant total";
                    label.Location = new Point(50, i * 30);
                    gbxReservation.Controls.Add((label));
                    label = new Label();
                    label.Text = ((double)jeuEnr3["montanttotal"]).ToString();
                    label.Location = new Point(175, i * 30);
                    gbxReservation.Controls.Add((label));
                    i += 1;
                    label = new Label();
                    label.Text = "Réglé par " + ((string)jeuEnr3["modereglement"]).ToString();
                    label.Location = new Point(50, i * 30);
                    label.Width = 200;
                    gbxReservation.Controls.Add((label));


                    maCnx3.Close();
                }
                catch (MySqlException er)
                {

                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
