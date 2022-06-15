using System;
using Equations_du_second_degré.Vue;

namespace Equations_du_second_degré.Controleur
{
    // Gère les interactions
    public class Controle
    {
        // Fenêtre d'authentification
        private frmSaisieEquation frmSaisieEquation;

        // Ouverture de la fenêtre
        public Controle()
        {
            frmSaisieEquation = new frmSaisieEquation(this);
            frmSaisieEquation.ShowDialog();
        }

        /// <summary>
        /// Fonction permettant d'afficher la fenêtre de Resolution
        /// Utilisation du paramètre equation pour afficher l'équation
        /// Utilisation des paramètres a,b,c pour récupérer les valeurs saisies
        /// Dans la frmResolution
        /// </summary>
        /// <param name="equation"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public Boolean Resolution(string equation, double a, double b, double c)
        {
            frmResolution abc = new frmResolution(this, equation, a, b, c);
            abc.ShowDialog(); 
            return true;
        }

        // Fonction permettant d'afficher la fenêtre de Saisie
        public Boolean Retour()
        {
            new frmSaisieEquation(this).ShowDialog();
            return true;
        }
    }
}
