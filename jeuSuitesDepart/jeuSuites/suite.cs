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

        public SuiteCartes()
        {
            for (int cpt = 0; cpt < longueurSuite; cpt++)
            {
                suiteCartes[cpt] = new Carte();
            }
        }

        public void GenererNouvelleSuiteCarte(int nombreCartes)
        {
            for (int cpt = 0; cpt < nombreCartes; cpt++)
            {
                suiteCartes[cpt].GenererCarte();
            }
        }
    }
}
