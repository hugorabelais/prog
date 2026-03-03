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
                    MessageBox.Show("port ajouté", "port ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (MySqlException er)
                {
                    Console.WriteLine("Erreur " + er.ToString());
                    MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Console.ReadLine();
        }
    }
}
