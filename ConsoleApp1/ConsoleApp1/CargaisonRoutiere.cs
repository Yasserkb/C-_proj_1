using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CargaisonRoutiere : Cargaison
    {
        public CargaisonRoutiere(string reference, double distance, double poid, double volume) : base(reference, distance, poid, volume)
        {
        }

        public override double CalculeCout()
        {
            double cout;
            if (this.volume < 380000)
                cout = 4 * this.distance * this.poid;
            else
                cout = 6 * this.distance * this.poid;
            return cout;
        }
    }
}
