using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CargaisonAerienne : Cargaison
    {
        public CargaisonAerienne(string reference, double distance, double poid, double volume) : base(reference, distance, poid, volume)
        {
        }

        public override double CalculeCout()
        {
            double cout;
            if (this.volume < 80000)
                cout = 10 * this.distance * this.poid;
            else
                cout = 12 * this.distance * this.poid;
            return cout;
        }
    }
}
