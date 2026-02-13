using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenetreGraphique
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            FormAfficherEditeur formAfficherEditeur = new FormAfficherEditeur();
            formAfficherEditeur.ShowDialog();

        }

        private void btnAjouterEditeur_Click(object sender, EventArgs e)
        {
            FormAjouterEditeur formAjouterEditeur = new FormAjouterEditeur();
            formAjouterEditeur .ShowDialog();
        }

        private void btnSuppripmerTitre_Click(object sender, EventArgs e)
        {
            FormSupprimerTitre formSupprimerTitre = new FormSupprimerTitre();
            formSupprimerTitre .ShowDialog();
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            FormAjouterLivre formAjouterLivre = new FormAjouterLivre();
            formAjouterLivre .ShowDialog();
        }
    }
}
