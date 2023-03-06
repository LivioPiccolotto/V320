using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Piccolotto_Livio
{
    public class Finanzamt
    {
        public int berechneSteuer(Steuerzahler[] steuerzahler)
        {
            int gesamtSteuer = 0;

            foreach (Steuerzahler zahler in steuerzahler)
            {
                gesamtSteuer += zahler.berechneSteuer();
            }

            return gesamtSteuer;
        }
    }
}
