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
    public partial class FormModifierBateau : Form
    {
        public FormModifierBateau()
        {
            InitializeComponent();
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

            try
            {
                MySqlConnection maCnx3;
                MySqlDataReader jeuEnr3 = null;
                maCnx3 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                Categorie categorie;
                Label label;
                TextBox textBox;
                int i = 1;
                maCnx3.Open();
                string requete = "select * from categorie";
                var maCde = new MySqlCommand(requete, maCnx3);
                jeuEnr3 = maCde.ExecuteReader();
                while (jeuEnr3.Read())
                {
                    string lettrecategorie = (string)jeuEnr3["lettrecategorie"];
                    string libelle = (string)jeuEnr3["libelle"];

                    categorie = new Categorie(lettrecategorie, libelle);
                    label = new Label();
                    label.Text = categorie.ToString();
                    label.Location = new Point(50, i * 30);
                    gbxCapacite.Controls.Add((label));
                    textBox = new TextBox();
                    textBox.Location = new Point(250, i * 30);
                    textBox.Tag = categorie.getlettrecategorie();
                    gbxCapacite.Controls.Add(textBox);
                    i += 1;
                }
                maCnx3.Close();
            }

            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbxNomBateau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxCapacite_Enter(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
                try
                {
                    MySqlConnection maCnx;
                    maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                    maCnx.Open();
                    string requete = "UPDATE contenir SET CAPACITEMAX = @capacite WHERE contenir.LETTRECATEGORIE = @lettrecategorie AND contenir.NOBATEAU = @nobateau";
                    string lettrecategorie;
                    Bateau bateau = (Bateau)cbxNomBateau.SelectedItem;
                    int nobateau = bateau.getnobateau();
                    var maCde = new MySqlCommand(requete, maCnx);
                    foreach (object control in gbxCapacite.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            lettrecategorie = textBox.Tag.ToString();
                            int capacite = int.Parse(textBox.Text);
                            var maCde2 = new MySqlCommand(requete, maCnx);
                            maCde2.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);
                            maCde2.Parameters.AddWithValue("@nobateau", nobateau);
                            maCde2.Parameters.AddWithValue("@capacite", capacite);
                            maCde2.ExecuteNonQuery();
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
