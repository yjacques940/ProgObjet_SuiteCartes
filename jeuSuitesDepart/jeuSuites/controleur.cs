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
        int tempsDuTimer = 20;
        int nombreMaximalDeSuitesGenerees = 5;
        int nombreEchecs;
        int pointsTotaux;
        int pointsDerniereSuite;
        int nombreEchecsMax = 2;

        public SuiteCartes suiteModele;
        public int nombreDeSuitesGenerees = 1;

        public Minuterie TempsJeu
        {
            get { return tempsJeu; }
        }

        public String NombreEchecs
        {
            get { return nombreEchecs.ToString(); }
        }

        public String PointsTotaux
        {
            get { return pointsTotaux.ToString(); }
        }

        public String PointsDerniereSuite
        {
            get { return pointsDerniereSuite.ToString(); }
        }

        public Controleur()
        {
            tempsJeu = new Minuterie();
            tempsJeu.FixerTemps(tempsDuTimer);
            suiteModele = new SuiteCartes();
            StartTimer();
        }

        private void StartTimer()
        {
            tempsJeu.Partir();
        }

        private void StopTimer()
        {
            tempsJeu.Arreter();
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
            tempsJeu.FixerTemps(tempsDuTimer);
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

        public void ConserverPointsDerniereSuite(int points)
        {
            pointsDerniereSuite = points;
        }

        public void AjouterPointsAuJoueur(int pointsAjouter)
        {
            pointsTotaux += pointsAjouter;
        }

        public void AjouterEchecAuJoueur()
        {
            nombreEchecs++;
        }

        public bool VerifierSiJoueurAtteintLimiteEchecs()
        {
            return (nombreEchecs == nombreEchecsMax);
        }

        public bool VerifierFinExecution()
        {
            bool partieTerminee = false;
            if (LeNombreMaximalDAffichageDeCarteAEteAtteint() || VerifierSiJoueurAtteintLimiteEchecs())
            {
                StopTimer();
                partieTerminee= true;
            }
            return partieTerminee;
        }

        public bool verifierSiSuiteEnOrdre()
        {
            return suiteModele.VerifierSiSuiteEnOrdre();
        }
    }
}
