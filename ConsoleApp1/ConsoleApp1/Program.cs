using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// avec MOHAMED BHAJY et ISMAIL BAOUAB 


namespace ConsoleApp1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
          
            Cargaison [] cargaisons = new Cargaison[4];
            CargaisonAerienne cargaisonAerienne = new CargaisonAerienne("f138",18,15,1990000);
            CargaisonAerienne cargaisonAerienne1 = new CargaisonAerienne("f139",20,10,70000);
            CargaisonRoutiere cargaisonRoutiere = new CargaisonRoutiere("f140", 14, 15, 390000);
            CargaisonRoutiere cargaisonRoutiere1 = new CargaisonRoutiere("f141", 16, 17, 370000);

            cargaisons[0] = cargaisonAerienne;
            cargaisons[1] = cargaisonAerienne1;
            cargaisons[2] = cargaisonRoutiere;
            cargaisons[3] = cargaisonRoutiere1;

            

            for(int i = 0; i < cargaisons.Length; i++)
            {
                if (cargaisons[i].CalculeCout() < 480000)
                    cargaisons[i].aff();
            }
            Console.ReadLine();
        }
    }
}
