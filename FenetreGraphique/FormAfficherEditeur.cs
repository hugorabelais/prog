using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace FenetreGraphique
{
    public partial class FormAfficherEditeur : Form
    {


        public FormAfficherEditeur()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            lvafficherediteur.Clear();
            NpgsqlConnection maCnx;
            NpgsqlDataReader jeuEnr = null;
            maCnx = new NpgsqlConnection("Server=127.0.0.1;Port=5432;" + "User Id=postgres;Password=postgres;Database=Biblio;");
            String lettre = tbxLettre.Text + "%";
            string requête;
            lvafficherediteur.View = View.Details;
            maCnx.Open(); // on se connecte
                            // NOTA BENE : title est un nom de champ, titles le nom de la table !
                            // DEBUT requête paramétrée
            requête = "select * from publishers where name like @lettre";
            var maCde = new NpgsqlCommand(requête, maCnx);
            maCde.Parameters.AddWithValue("@lettre", lettre);
            jeuEnr = maCde.ExecuteReader();
            
            lvafficherediteur.Columns.Add("nom editeur", 100);
            lvafficherediteur.Columns.Add("pubid", 50);
            var tabItem = new string[4];
            while (jeuEnr.Read())
                {
                tabItem[0] = jeuEnr["name"].ToString();
                tabItem[1] = jeuEnr["pubid"].ToString();
                lvafficherediteur.Items.Add(new ListViewItem(tabItem));

            }
                    maCnx.Close(); // on se déconnecte
                
            

        }

        private void lvafficherediteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
