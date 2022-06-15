using System;
using System.Windows.Forms;
using Equations_du_second_degré.Controleur;

namespace Equations_du_second_degré.Vue
{
    public partial class frmResolution : Form
    {
        //Récupération du controleur
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// </summary>
        /// Les paramètres suivants sont récupérés de la frmSaisieEquation
        /// Pour permettre l'utilisation de leurs données dans la frmResolution
        /// <param name="controle"></param>
        /// <param name="equation"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public frmResolution(Controle controle, string equation, double a, double b, double c)
        {
            InitializeComponent();
            this.controle = controle;

            //L'utilisateur ne peut pas saisir de données dans ces box
            txtDelta.Enabled = false;
            txtEquation.Enabled = false;
            txtSolutions.Enabled = false;
            txtSolution2.Enabled = false;

            //Masque la txtBox si il n'y a pas deux solutions
            txtSolution2.Visible = false;

            //Affichage de l'équation saisie dans la frmSaisie
            txtEquation.Text = equation;

            //Calcul de delta (b² - 4c)
            double delta = b * b - 4 * a * c;

            //Convertit le calcul delta en chaine de caractères
            txtDelta.Text = delta.ToString();

            //Application de la formule si 2 solutions
            if (delta > 0)
            {
                double solutionx1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double solutionx2 = (-b + Math.Sqrt(delta)) / (2 * a);
                txtSolutions.Text = " x1 = " + solutionx1.ToString();
                txtSolution2.Text = " x2 = " + solutionx2.ToString();
                txtSolution2.Visible = true;
            }

            //Application de la formule si 1 solution
            if (delta == 0)
            {
                double solutionO = -b / (2 * a);
                txtSolutions.Text = " x = " + solutionO.ToString();
            }

            //Pas de solution si delta < 0
            else
            {
                txtSolutions.Text = "Pas de solution";
            }
        }

        /// <summary>
        /// Renvoie à la fenêtre de saisie d'une équation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            controle.Retour();
        }
    }
}
