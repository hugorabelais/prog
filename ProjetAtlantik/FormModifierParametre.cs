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
    public partial class FormModifierParametre : Form
    {
        public FormModifierParametre()
        {
            InitializeComponent();
            int i = 2;
            Label label;
            TextBox textBox;
            label = new Label();
            label.Text = "Site :";
            label.Location = new Point(50, i * 30);
            gbxPayBox.Controls.Add((label));
            i++;
            label = new Label();
            label.Text = "Rang :";
            label.Location = new Point(50, i * 30);
            gbxPayBox.Controls.Add((label));
            i++;
            label = new Label();
            label.Text = "Identifiant :";
            label.Location = new Point(50, i * 30);
            gbxPayBox.Controls.Add((label));
            i++;
            label = new Label();
            label.Text = "Clé HMAC :";
            label.Location = new Point(50, i * 30);
            gbxPayBox.Controls.Add((label));
            try
            {
                MySqlConnection maCnx3;
                MySqlDataReader jeuEnr3 = null;
                maCnx3 = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx3.Open();
                string requete = "select * from parametres";
                var maCde = new MySqlCommand(requete, maCnx3);
                jeuEnr3 = maCde.ExecuteReader();
                jeuEnr3.Read();
                i = 2;
                string site_pb = (string)jeuEnr3["site_pb"];
                string rang_pb = (string)jeuEnr3["rang_pb"];
                string identifiant_pb = (string)jeuEnr3["identifiant_pb"];
                string clehmac_pb = (string)jeuEnr3["clehmac_pb"];
                textBox = new TextBox();
                textBox.Text = site_pb;
                textBox.Tag = "site_pb";
                textBox.Location = new Point(200, i * 30);
                gbxPayBox.Controls.Add((textBox));
                i++;
                textBox = new TextBox();
                textBox.Text = rang_pb;
                textBox.Tag = "rang_pb";
                textBox.Location = new Point(200, i * 30);
                gbxPayBox.Controls.Add((textBox));
                i++;
                textBox = new TextBox();
                textBox.Text = identifiant_pb;
                textBox.Tag = "identifiant_pb";
                textBox.Location = new Point(200, i * 30);
                gbxPayBox.Controls.Add((textBox));
                i++;
                textBox = new TextBox();
                textBox.Text = clehmac_pb;
                textBox.Tag = "clehmac_pb";
                textBox.Location = new Point(200, i * 30);
                gbxPayBox.Controls.Add((textBox));
                i++;

                maCnx3.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection maCnx;
                maCnx = new MySqlConnection("server=localhost;user=root;database=Atlantik;port=3306;password=");
                maCnx.Open();
                string requete = "UPDATE parametres SET SITE_PB =@site_pb , RANG_PB =@rang_pb , IDENTIFIANT_PB = @identifiant_pb, CLEHMAC_PB =@clehmac_pb , ENPRODUCTION =@enProduction , MELSITE =@mel";
                string site_pb = "a";
                string rang_pb = "a";
                string identifiant_pb = "a";
                string clehmac_pb = "a";
                int enProduction = cbxEnProduction.Checked ? 1 : 0;
                string mel = tbxMelSite.Text;
                var maCde = new MySqlCommand(requete, maCnx);
                foreach (object control in gbxPayBox.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox) control;
                        if ((string)textBox.Tag == "site_pb")
                        {
                            site_pb = textBox.Text;
                        }
                        else if ((string)textBox.Tag == "rang_pb")
                        {
                            rang_pb = textBox.Text;
                        }
                        else if ((string)textBox.Tag == "identifiant_pb")
                        {
                            identifiant_pb = textBox.Text;
                        }
                        else
                        {
                            clehmac_pb = textBox.Text;
                        }

                    var maCde2 = new MySqlCommand(requete, maCnx);
                    maCde2.Parameters.AddWithValue("@site_pb", site_pb);
                    maCde2.Parameters.AddWithValue("@rang_pb", rang_pb);
                    maCde2.Parameters.AddWithValue("@identifiant_pb", identifiant_pb);
                    maCde2.Parameters.AddWithValue("@clehmac_pb", clehmac_pb);
                    maCde2.Parameters.AddWithValue("@enProduction", enProduction);
                    maCde2.Parameters.AddWithValue("@mel", mel);
                    maCde2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("paramètres modifiés", "les paramètres ont été modifiés", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                maCnx.Close();
            }
            catch (MySqlException er)
            {

                MessageBox.Show("erreur", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
