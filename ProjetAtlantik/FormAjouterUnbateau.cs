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
    public partial class FormAjouterUnbateau : Form
    {
        public FormAjouterUnbateau()
        {
            InitializeComponent();
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
                    gbxCapaciteMax.Controls.Add((label));
                    textBox = new TextBox();
                    textBox.Location = new Point(250, i * 30);
                    textBox.Tag = categorie.getlettrecategorie();
                    gbxCapaciteMax.Controls.Add(textBox);
                    i += 1;
                }
                maCnx3.Close();
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
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx.Open();
                string requeteBateau = "insert into bateau (nom) values (@nom)";
                string lettrecategorie;
                string nom = tbxNomBateau.Text;
                var maCde = new MySqlCommand(requeteBateau, maCnx);
                maCde.Parameters.AddWithValue("@nom", nom);
                maCde.ExecuteNonQuery();
                int nobateau = (int)maCde.LastInsertedId;
                maCnx.Close();
               
                MySqlConnection maCnx2;
                MySqlDataReader jeuEnr2 = null;
                maCnx2 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx2.Open();
                string requeteContenir = "insert into contenir (lettrecategorie, nobateau,capacitemax) values (@lettrecategorie,@nobateau,@capacitemax)";
                foreach (object control in gbxCapaciteMax.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        lettrecategorie = textBox.Tag.ToString();
                        int capacite = int.Parse(textBox.Text);
                        var maCde2 = new MySqlCommand(requeteContenir, maCnx2);
                        maCde2.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);
                        maCde2.Parameters.AddWithValue("@nobateau", nobateau);
                        maCde2.Parameters.AddWithValue("@capacitemax", capacite);
                        maCde2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("tarifs ajoutés", "tous les tarifs ont été ajoutés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
