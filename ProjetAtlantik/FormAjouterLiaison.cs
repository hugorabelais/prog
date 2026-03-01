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

namespace ProjetAtlantik
{
    public partial class FormAjouterLiaison : Form
    {
        public FormAjouterLiaison()
        {
            InitializeComponent();
            try
            {
                NpgsqlConnection maCnx;
                NpgsqlDataReader jeuEnr = null;
                maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=root;Database=Atlantik;");
                Secteur secteur;
                maCnx.Open();
                string requete = "select * from secteur";
                var maCde = new NpgsqlCommand(requete, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    secteur = new Secteur((int)jeuEnr["nosecteur"], (string)jeuEnr["nom"]);
                    lbxSecteur.Items.Add(secteur.ToString());
                }
                maCnx.Close();
            }
            catch (NpgsqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                NpgsqlConnection maCnx2;
                NpgsqlDataReader jeuEnr2 = null;
                maCnx2 = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=root;Database=Atlantik;");
                Port port;
                maCnx2.Open();
                string requete2 = "select * from port";
                var maCde2 = new NpgsqlCommand(requete2, maCnx2);
                jeuEnr2 = maCde2.ExecuteReader();

                while (jeuEnr2.Read())
                {
                    port = new Port((int)jeuEnr2["noport"], (string)jeuEnr2["nom"]);
                    lbxPortDepart.Items.Add(port.ToString());
                    lbxPortArrivee.Items.Add(port.ToString());
                }
            }
            catch (NpgsqlException er)
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
            try
            {
                NpgsqlConnection maCnx;
                NpgsqlDataReader jeuEnr = null;
                maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=root;Database=Atlantik;");
                int distance = int.Parse(tbxDistance.Text);
                string requete = "insert into liaison (noport_depart, nosecteur, noport_arrivee,distance) values (@noport_depart, @nosecteur, @noport_arrivee,@distance)";
                var maCde = new NpgsqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@noport_depart", ((Port)lbxPortDepart.SelectedItem).getidPort());
                maCde.Parameters.AddWithValue("@nosecteur", ((Secteur)lbxSecteur.SelectedItem).getidSecteur());
                maCde.Parameters.AddWithValue("@nosecteur", ((Port)lbxPortArrivee.SelectedItem).getidPort());
                maCde.Parameters.AddWithValue("@distance",distance);
                maCde.ExecuteNonQuery();
                MessageBox.Show("liaison ajouté", "liaison ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                maCnx.Close();
            }
            catch (NpgsqlException er)
            {
               
                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

    }
}
