using System;
using System.Windows.Forms;
using System.Drawing;




public class PremiereFenetre : Form

{

    private Label lblMessage;

    private Label lblMessage1;

    private Button btnFermer;

    private int x;
    private int y;



    public PremiereFenetre()

    {

        SuspendLayout();

        Text = "Une première fenêtre";    // Le titre de la fenêtre

        Size = new Size(1000, 1000);        // La taille initiale

        MinimumSize = new Size(200, 150); // La taille minimale



        // Le label "Hello world !"

        lblMessage1 = new Label();

        lblMessage1.Text = "Hello World !";

        lblMessage1.AutoSize = true;             // Taille selon le contenu

        lblMessage1.Location = new Point(50, 30);// Position x=50 y=30


        lblMessage = new Label();

        lblMessage.Text = "c'est guingamp batard!";

        lblMessage.AutoSize = true;             // Taille selon le contenu

        lblMessage.Location = new Point(500, 500);


        // Le bouton "Fermer"

        btnFermer = new Button();

        btnFermer.Text = "Fermer";

        btnFermer.AutoSize = true;             // Taille selon le contenu

        btnFermer.Location = new Point(x, y);// Position x=50 y=60



        btnFermer.Click += new System.EventHandler(btnFermer_Click); /* Si Click sur « btnFermer » on appelle la méthode « btnFermer_Click ») */



        // Ajouter les composants à la fenêtre

        Controls.Add(lblMessage1);
        Controls.Add(lblMessage);
        for (int i = 0; i < 10; i++) { 
            for (int j = 0; j < 10; j++) 
                {
                    Controls.Add(btnFermer);

                    
                    btnFermer = new Button();
                    btnFermer.Text = "Fermer";
                    btnFermer.AutoSize = true;             // Taille selon le contenu
                    btnFermer.Location = new Point(x, y);
                    x += 70;
                }
                y += 70;
                x = 0;
            }


        ResumeLayout(false);

        PerformLayout();

    }



    // Gestionnaire d'événement

    private void btnFermer_Click(object sender, EventArgs evt)

    {

        // Fin de l'application :

        Application.Exit();

    }



    static void Main()

    {

        // Pour le style XP :

        Application.EnableVisualStyles();



        // Lancement de la boucle de messages

        // pour la fenêtre passée en argument :

        Application.Run(new PremiereFenetre());

    }

}
