﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuSuites
{
    class Controleur
    {
        Minuterie tempsJeu;
        int nombreMaximalDeSuitesGenerees = 5;
        public int nombreDeSuitesGenerees = 1;
        public SuiteCartes suiteModele;

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
            GenererNouvelleSuite();
            tempsJeu.FixerTemps(10);
            tempsJeu.Partir();
        }

        internal void GenererNouvelleSuite()
        {
            //suiteModele.GenererNouvelleSuiteCarte();
            AugmenterNombreDeSuiteGeneree();
        }

        public void AugmenterNombreDeSuiteGeneree()
        {
            nombreDeSuitesGenerees++;
        }
    }
}
