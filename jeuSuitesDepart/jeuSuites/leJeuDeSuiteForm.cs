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
            AfficherInformations();
        }

        private void AfficherInformations()
        {
            AfficherTempsRestant();
            AfficherNombreDeSuiteGenerees();
        }

        private void AfficherNombreDeSuiteGenerees()
        {
            nombreDeSuitesGenereesLabel.Text = leJeuDeSuite.nombreDeSuitesGenerees.ToString();
        }

        private void AbonnerEvenement()
        {
            leJeuDeSuite.TempsJeu.SecondeTic += minuterie_SecondeTic;
            leJeuDeSuite.TempsJeu.FinMinuterie += minuterie_FinMinuterie;
        }

        private void minuterie_FinMinuterie(object sender, EventArgs e)
        {
            leJeuDeSuite.MinuterieTerminee();
            VerifierFinExecution();
            AfficherInformations();
        }

        private void VerifierFinExecution()
        {
            if (leJeuDeSuite.LeNombreMaximalDAffichageDeCarteAEteAtteint())
            {
                Close();
            }
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

        private void buttonNextSuite_Click(object sender, EventArgs e)
        {

        }

        private void AfficherLesCartes()
        {
            card1Label.Text = leJeuDeSuite.suiteModele.getCarte(1);
            card2Label.Text = leJeuDeSuite.suiteModele.getCarte(2);
            card3Label.Text = leJeuDeSuite.suiteModele.getCarte(3);
            card4Label.Text = leJeuDeSuite.suiteModele.getCarte(4);
            card5Label.Text = leJeuDeSuite.suiteModele.getCarte(5);
        }
    }
}
