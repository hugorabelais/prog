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
    public partial class FormAcceuil : Form
    {
        public FormAcceuil()
        {
            InitializeComponent();
        }

        private void miSecteur_Click(object sender, EventArgs e)
        {
            FormSecteur formSecteur = new FormSecteur();
            formSecteur.ShowDialog();
        }

        private void miAjouterPort_Click(object sender, EventArgs e)
        {
            FormAjouterPort formAjouterPort = new FormAjouterPort();
            formAjouterPort.ShowDialog();
        }

        private void uneLiaisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterLiaison formAjouterLiaison = new FormAjouterLiaison();
            formAjouterLiaison.ShowDialog();

        }


        private void milesTarifsPourUneLiaisonEtUnePériode_Click(object sender, EventArgs e)
        {
            FormTarifLiasonPeriode formTar = new FormTarifLiasonPeriode();
            formTar.ShowDialog();
        }



        private void miAjouterUnBateau_Click(object sender, EventArgs e)
        {
            FormAjouterUnbateau form = new FormAjouterUnbateau();
            form.ShowDialog();
        }

        private void miModifierBateau_Click(object sender, EventArgs e)
        {
            FormModifierBateau form = new FormModifierBateau();
            form.ShowDialog();
        }

        private void miAjouterUneTraversée_Click(object sender, EventArgs e)
        {
            FormAjouterTraverse formAjouterTraverse = new FormAjouterTraverse();
            formAjouterTraverse.ShowDialog();
        }

        private void miAfficherLiaison_Click(object sender, EventArgs e)
        {
            FormAfficherLiaison form = new FormAfficherLiaison();
            form.ShowDialog();
        }
    }
}
