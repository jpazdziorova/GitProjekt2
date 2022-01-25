using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.DatumNarozeni = DateTime.Parse("01.03.2000");
            Console.WriteLine(osoba.DatumNarozeni);
            Console.WriteLine(osoba.Vek());

            Console.ReadKey();
        }
    }
}
