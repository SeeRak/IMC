using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class IHM : Form
    {
        // Déclaration des attributs
        private bool sexe;
        private int taillecm;
        private double poids;
        private double imc;
        private double poidsideal;

        public IHM()
        {
            InitializeComponent();
        }

        private void buttonFemme_Click(object sender, EventArgs e)
        {
            string ChaineTaille = "";
            ChaineTaille = textBoxTaille.Text;
            
            int taillecm = int.Parse(ChaineTaille);     // Récupération du texte et conversion en un type réel
            double Lorentz = taillecm - 100 - ((taillecm - 150) / 2.4);   // Calcul Valeur IMC Lorentz
            double Devine = 45.5 + 2.3 * ((taillecm/2.54)-60);
            double Total = Math.Round((Lorentz + Devine) / 2, 2);     // Calcul Valeur IMC Lorentz

            textBoxIdeal.Text = Total.ToString(".##"); //Conversion d'un type réel en string avant de l'affecter à la propriété "Text"

            string ChainePoids = "";
            ChainePoids = textBoxPoids.Text;

            double poids = double.Parse(ChainePoids);
            imc = Math.Round((poids / (Math.Pow((taillecm / 100.0), 2))), 2);
            textBoxValeur.Text = imc.ToString();

           textBoxCatégorie.Text= CategorieIMC();
        }

        private void buttonHomme_Click(object sender, EventArgs e)
        {
            string ChaineTaille = "";
            ChaineTaille = textBoxTaille.Text;

            int taillecm = int.Parse(ChaineTaille);     // Récupération du texte et conversion en un type réel
            double Lorentz = taillecm - 100 - ((taillecm - 150) / 4.0);   // Calcul Valeur IMC Lorentz
            double Devine = 50 + 2.3 * ((taillecm/2.54)-60);
            double Total = Math.Round((Lorentz + Devine) / 2 , 2);
            

            textBoxIdeal.Text = Total.ToString(); //Conversion d'un type réel en string avant de l'affecter à la propriété "Text"


            string ChainePoids = "";
            ChainePoids = textBoxPoids.Text;

            double poids = double.Parse(ChainePoids);
            imc= Math.Round((poids / (Math.Pow((taillecm / 100.0),2))),2);
            textBoxValeur.Text = imc.ToString();

            textBoxCatégorie.Text = CategorieIMC();
        }


        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();    // Bouton Quitter
        }
        private string CategorieIMC()
        {
            string imcString = "Maigreur sévère";
           // imcString = textBoxCatégorie.Text;

            if (16.5 < imc && imc < 18.99)
                imcString = "Maigreur";

            if (18.5 < imc && imc < 24.99)
                imcString = "Normal";

            if (24.5 < imc && imc < 29.99)
                imcString = "Surcharge";

            if (30 < imc && imc < 34.99)
                imcString = "Obésité Modérée";

            if (35 < imc && imc < 39.99)
                imcString = "Obésité Sévère";

            if (imc > 40)
                imcString = "Obésité Modbide";

            return imcString;
        }      
    }
}
