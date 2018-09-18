using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuSuites
{
    class Controleur
    {
        Minuterie tempsJeu;
        int nombreMaxDeCartes = 5;
        int nombreMaximalDeSuitesGenerees = 5;
        int nombreEchecs;
        int pointsTotaux;
        public SuiteCartes suiteModele;
        public int nombreDeSuitesGenerees = 1;

        public Minuterie TempsJeu
        {
            get { return tempsJeu; }
        }

        public Controleur()
        {
            tempsJeu = new Minuterie();
            tempsJeu.FixerTemps(10);
            suiteModele = new SuiteCartes();
            StartTimer();
        }

        private void StartTimer()
        {
            tempsJeu.Partir();
        }

        public bool LeNombreMaximalDAffichageDeCarteAEteAtteint()
        {
            if(nombreMaximalDeSuitesGenerees < nombreDeSuitesGenerees)
            {
                return true;
            }
            return false;
        }

        internal void MinuterieTerminee()
        {          
            AugmenterNombreDeSuiteGeneree();
            GenererNouvelleSuite();
            tempsJeu.FixerTemps(20);
            tempsJeu.Partir();
        }

        internal void GenererNouvelleSuite()
        {
            suiteModele.GenererNouvelleSuiteCarte();
        }

        public void AugmenterNombreDeSuiteGeneree()
        {
            nombreDeSuitesGenerees++;
        }

        public void AjouterPointsAuJoueur(int pointsAjouter)
        {
            pointsTotaux += pointsAjouter;
        }

        public void AjouterEchecAuJoueur()
        {
            nombreEchecs++;
        }

    }
}
