using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato c= new Quadrato();
           Quadrato c1 = c;
            Console.WriteLine("inserisci il valore del lato "); 
            c1.sezione=float.Parse(Console.ReadLine());
            float superfice; 
            Console.WriteLine("il valore della superfice del quadrato è {0}",c1.sezione*c1.sezione);
            Console.ReadLine();

        }
    }
}
