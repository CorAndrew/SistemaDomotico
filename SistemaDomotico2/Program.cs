using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomotico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISwitchable> interruttoriGenerali = new List<ISwitchable>
            {
                new Lampadina("Luce Soggiorno", "Salotto", 100),
                new Termostato("Termostato Master", "Corridoio", 20.0),
                new Allarme()
            };

            foreach (ISwitchable dispositivo in interruttoriGenerali)
            {
                dispositivo.Accendi();

                if (dispositivo is DispositivoSmart smartDev)
                {
                    Console.WriteLine(smartDev.MostraDettagli());
                }
                else
                {
                    Console.WriteLine($"[Allarme] Stato: Attivato");
                }
            }

            foreach (ISwitchable dispositivo in interruttoriGenerali)
            {
                dispositivo.Spegni();

                if (dispositivo is DispositivoSmart smartDev)
                {
                    Console.WriteLine(smartDev.MostraDettagli());
                }
                else
                {
                    Console.WriteLine($"[Allarme] Stato: Disattivato");
                }
            }
        }
    }
}
