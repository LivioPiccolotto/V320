using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steuern_Piccolotto_Livio
{
    // Definition des Interface
    public interface ISteuerzahler
    {
        int berechneSteuer();
    }

    // Implementierung der Klasse
    public class Steuerzahler : ISteuerzahler
    {
    
       
        public int berechneSteuer()
        {
            // Hier könnte die Steuerberechnung erfolgen
            
            return (int)Math.Round("einkommen");
        }
    }

}
