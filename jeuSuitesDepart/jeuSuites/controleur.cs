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
        public SuiteCartes suiteModele;
        int nombreMaximalAffichageDeSuites = 5;
        int nombreActuelDaffichageDeSuites = 0;

        public Minuterie TempsJeu
        {
            get { return tempsJeu; }
        }

        public Controleur()
        {
            tempsJeu = new Minuterie();
            tempsJeu.FixerTemps(20);
            suiteModele = new SuiteCartes();
            StartTimer();
        }

        private void StartTimer()
        {
            tempsJeu.Partir();
        }

        public bool LeNombreMaximalDAffichageDeCarteAEteAtteint()
        {
            if(nombreMaximalDeSuitesGenerees == nombreDeSuitesGenerees)
            {
                return true;
            }
            return false;
        }

        public void AugmenterNombreDeSuiteGeneree()
        {
            nombreDeSuitesGenerees++;
        }
    }
}
