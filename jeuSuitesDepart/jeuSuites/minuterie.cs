using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuSuites
{
    class Minuterie
    {
        int secondes;
        System.Windows.Forms.Timer  timerMinuterie;
	  
        public int Secondes
        {
            get { return secondes; }
        }
        public event EventHandler SecondeTic;
        public event EventHandler FinMinuterie;
        public Minuterie()
        {
            secondes = 0;
            InitialiserTimerMinuterie();
        }
        public void FixerTemps(int sec)
        {
            secondes = sec;
        }
        void InitialiserTimerMinuterie()
        {
            timerMinuterie = new System.Windows.Forms.Timer();
            timerMinuterie.Interval = 1000;
            timerMinuterie.Enabled = false;
            timerMinuterie.Tick += TimerMinuterie_Tick;
        }
        private void TimerMinuterie_Tick(object sender, EventArgs e)
        {
            secondes--;
            if (SecondeTic != null)
            {
                SecondeTic(this, new EventArgs());
            }
            if (secondes == 0)
            {
                Arreter();
                if (FinMinuterie != null)
                {
                    FinMinuterie(this, new EventArgs());
                }
            }
        }
        public void Partir()
        {
            timerMinuterie.Enabled = true;
            if (SecondeTic != null)
            {
                SecondeTic(this, new EventArgs());
            }
        }
        public void Arreter()
        {
            timerMinuterie.Enabled = false;
        }
    }
}
