using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Cargaison
    {
        private static int counter;
        private readonly int _id;
        protected string reference;
        protected double distance;
        protected double poid;
        protected double volume;

        protected Cargaison(string reference, double distance, double poid, double volume)
        {
            this._id =++Cargaison.counter;
            this.reference = reference;
            this.distance = distance;
            this.poid = poid;
            this.volume = volume;
        }


        public abstract double CalculeCout();

       

        public override string ToString()
        {
            string s = " id : " + this._id +" reference : " + this.reference + " distance : "+this.distance + " poids : "+ this.poid + " volume : " + volume ;
            return s;
        }
        public void aff()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
