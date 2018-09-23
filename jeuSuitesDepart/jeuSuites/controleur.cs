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
            return (nombreMaximalDeSuitesGenerees < nombreDeSuitesGenerees);
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

        internal void ModifierPositions(List<string> positions)
        {
            suiteModele.ChangerPositionDesCartes(positions);
            suiteModele.ChangerPositions();
        }

        internal bool PositionsAreInRange(List<string> positions)
        {
            if (ArePositionsInRange(positions))
            {
                ModifierPositions(positions);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ArePositionsInRange(List<string> positions)
        {
            foreach (var position in positions)
            {
                if(position == string.Empty)
                {
                    return false;
                }
                else
                {
                    var positionInInteger = Int32.Parse(position);
                    if (positionInInteger < 6 && positionInInteger > 0)
                    {
                        return true;
                    }
                }
            }
           return false;
        }

    }
}
