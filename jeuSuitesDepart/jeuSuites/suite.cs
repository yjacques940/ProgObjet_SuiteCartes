using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuSuites
{
    class SuiteCartes
    {
        public  const int longueurSuite = 5;
        static Random generateurSuite = new Random();

        Carte[] suiteCartes = new Carte[longueurSuite];

        public event EventHandler SuiteReussie;

        public string getCarte(int index)
        {
           return suiteCartes[index].ValeurCarte; 
        }

        public SuiteCartes()
        {
            for (int cpt = 0; cpt < longueurSuite; cpt++)
            {
                suiteCartes[cpt] = new Carte();
            }
        }

        public void GenererNouvelleSuiteCarte()
        {
            for (int cpt = 0; cpt < longueurSuite; cpt++)
            {
                suiteCartes[cpt].GenererCarte();
            }
        }

        private void VerifierSiSuiteEnOrdre()
        {
            bool enOrdre = false;
            for (int cpt = 0; cpt<longueurSuite;cpt++)
            {
                if (suiteCartes[cpt] > suiteCartes[cpt])
                {
                    enOrdre = false;
                }
            }
            if (enOrdre)
            {
                SuiteReussie(this, new PointsSuiteReussiEventArgs(suiteCartes[]));
            }
        }
    }

    class PointsSuiteReussiEventArgs : EventArgs
    {
        //attribut qui sert à garder la valeur qui sera dans le paramètre e
        int points;
        //propriété qui permettra d'accéder à cette valeur
        public int Points
        {
            get { return points; }
        }
        //constructeur qui sera utilisé lorsqu'on déclenchera l'événement
        public PointsSuiteReussiEventArgs(int[] suite)
        {
            for(int cpt = 0; cpt<= SuiteCartes.longueurSuite; cpt++)
            {
                points += suite[cpt];
            }
        }
    }
}
