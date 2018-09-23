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
        Carte[] suiteCartesModifiee = new Carte[longueurSuite];

        public delegate void PointsSuiteReussiEventHandler(Object sender, PointsSuiteReussiEventArgs e);
        public event PointsSuiteReussiEventHandler SuiteReussie;

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

        public bool VerifierSiSuiteEnOrdre()
        {
            bool enOrdre = true;
            for (int cpt = 0; cpt<longueurSuite-1;cpt++)
            {
                if (suiteCartes[cpt] > suiteCartes[cpt+1])
                {
                    enOrdre = false;
                }
            }
            if (enOrdre)
            {
                SuiteReussie(this, new PointsSuiteReussiEventArgs(suiteCartes));                
            }
            return enOrdre;
        }

        internal int GetLongueurSuite()
        {
            return longueurSuite;
        }

        public void ChangerPositionDesCartes(List<string> positions)
        {
            ViderLaSuiteModifiee();
            var count = 0;
            foreach (var newPosition in positions)
            {
                var position = Int32.Parse(newPosition);
                if(suiteCartesModifiee[position-1] == null)
                {
                    suiteCartesModifiee[position - 1] = suiteCartes[count];
                }
                else if(position < longueurSuite)
                {
                    suiteCartesModifiee[position] = suiteCartes[count];
                }
                else
                {
                    suiteCartesModifiee[longueurSuite-1] = suiteCartes[count];
                }
                
                count++;
            }
        }

        private void ViderLaSuiteModifiee()
        {
            for (int cpt = 0; cpt < longueurSuite - 1; cpt++)
            {
                suiteCartesModifiee[cpt] = new Carte();
            }
        }

        public void ChangerPositions()
        {
            suiteCartes = suiteCartesModifiee;
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
        public PointsSuiteReussiEventArgs(Carte[] suite)
        {
            for(int cpt = 0; cpt< SuiteCartes.longueurSuite; cpt++)
            {
                points += suite[cpt].ValeurChiffreCarte;
            }
        }
    }
}
