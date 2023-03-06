using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Piccolotto_Livio
{
    public class Person : Steuerzahler
    {
        private int einkommen;
        private bool istBanker;

        public Person(int einkommen, bool istBanker)
        {
            this.einkommen = einkommen;
            this.istBanker = istBanker;
        }

        public int Einkommen
        {
            get { return einkommen; }
            set { einkommen = value; }
        }

        public int ermittleZuVersteuerndesEinkommen()
        {
            int zuVersteuerndesEinkommen = einkommen - 2400;
            if (zuVersteuerndesEinkommen < 0)
            {
                zuVersteuerndesEinkommen = 0;
            }
            return zuVersteuerndesEinkommen;
        }

        public int berechneSteuer()
        {
            double steuersatz = 0.25;
            int zuVersteuerndesEinkommen = ermittleZuVersteuerndesEinkommen();
            int steuer = (int)Math.Round(zuVersteuerndesEinkommen * steuersatz);
            if (istBanker)
            {
                steuer += 1000;
            }
            if (steuer > einkommen)
            {
                steuer = einkommen;
            }
            return steuer;
        }
    }

}
