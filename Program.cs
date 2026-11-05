using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lestsgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom= "Njaraniaina";
            string adresse = "BoysDormVohitsoa";
            int matricule = 30263;

            Console.WriteLine("===========================================================================");
            Console.WriteLine("\t\t\t\t\tRECAPITULATIO");
            Console.WriteLine("===========================================================================");

            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine(($"Nom: {nom}"));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(($"Adresse: {adresse}"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(($"Matricule: {matricule}"));
        }
    }
}
