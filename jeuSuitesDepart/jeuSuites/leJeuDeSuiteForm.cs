using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeuSuites
{
    public partial class leJeuDeSuiteForm : Form
    {
        Controleur leJeuDeSuite = new Controleur();

        public leJeuDeSuiteForm()
        {
            InitializeComponent();
            leJeuDeSuite = new Controleur();
            AbonnerEvenement();
            AfficherTempsRestant();
        }

        private void AbonnerEvenement()
        {
            leJeuDeSuite.TempsJeu.SecondeTic += minuterie_SecondeTic;
        }

        private void minuterie_SecondeTic(object sender, EventArgs e)
        {
            AfficherTempsRestant();
        }

        private void AfficherTempsRestant()
        {
            remainingTimeLabel.Text = leJeuDeSuite.TempsJeu.Secondes.ToString() + " secondes";
        }

        private void TerminerExecution()
        {
            if(leJeuDeSuite.LeNombreMaximalDAffichageDeCarteAEteAtteint())
            {
                Close();
            }
        }
    }
}
