using System;
using System.Windows.Forms;
using Equations_du_second_degré.Controleur;

namespace Equations_du_second_degré
{
    public partial class frmSaisieEquation : Form
    {
        //Récupération du controleur
        private Controle controle;

        /// <summary>
        /// Initialisation de l'interface graphique et du controleur
        /// </summary>
        /// <param name="controle"></param>
        public frmSaisieEquation(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            txtEquation.Enabled = false;
        }

        /// <summary>
        /// Saisie des 3 variables
        /// Enregistrement des saisies dans les variables a,b,c
        /// Puis affichage dans la txtBox "Equation"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!txtA.Text.Equals("") && !txtB.Text.Equals("") && !txtC.Text.Equals(""))
            {
                a = double.Parse(txtA.Text);
                b = double.Parse(txtB.Text);
                c = double.Parse(txtC.Text);
                txtEquation.Text = a + "x² + "+ b + "x + " + c;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Information");
            }
           
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtEquation.Text = "";
        }

        /// <summary>
        /// Fonction permettant de contrôler la saisie 
        /// Les caractères doivent être des entiers ou des décimaux
        /// Les virgules et les points sont autorisés
        /// La touche effacer doit être fonctionnelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsPunctuation(e.KeyChar) || (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Veuillez saisir un nombre entier ou décimal.", "Alerte");
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        /// <summary>
        /// Le clic permet d'accéder à la fenêtre de la résolution de l'équation
        /// On doit d'abord masquer la fenêtre actuelle
        /// Puis on passe à la Form Resolution
        /// On ajoute les arguments , txtEquation, a, b , c pour pouvoir les récupérer dans la frmResolution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResoudre_Click(object sender, EventArgs e)
        {
            if (txtA.Text.Equals("") || txtB.Text.Equals("") || txtC.Text.Equals(""))
            {
                MessageBox.Show("Vous devez remplir tous les champs", "Alerte");
                return;
            }
            if (txtEquation.Text.Equals(""))
            {
                MessageBox.Show("Vous devez d'abord cliquer sur 'Valider' pour enregistrer votre équation.", "Alerte");
                return;
            }

            this.Hide();
            // Convertit les txtBox en type double 
            double a, b, c;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);
            controle.Resolution(txtEquation.Text, a, b, c);
        }
    }
}
