using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomoticoP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampadina lampada = new Lampadina("Luce Salotto", "Salotto", 80);
            Termostato termostato = new Termostato("Termo1", "Cucina", 21.5);


            List<Lampadina> lampadine = new List<Lampadina> { lampada };
            List<Termostato> termostati = new List<Termostato> { termostato };

            Console.WriteLine("Accensione Lampadine");
            foreach (Lampadina l in lampadine)
            {
                l.Accendi();
            }

            Console.WriteLine("Accensione Termostati");
            foreach (Termostato t in termostati)
            {
                t.Accendi();
            }
        }
    }
}
