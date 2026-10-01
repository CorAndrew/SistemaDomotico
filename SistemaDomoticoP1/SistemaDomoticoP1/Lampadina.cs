using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomoticoP1
{
    public class Lampadina
    {
        public string Nome { get; set; }
        public string Stanza { get; set; }
        public int Luminosita { get; set; }
        public bool IsAcceso { get; private set; }

        public Lampadina(string nome, string stanza, int luminosita)
        {
            Nome = nome;
            Stanza = stanza;
            Luminosita = luminosita;
            IsAcceso = false;
        }

        public void Accendi()
        {
            IsAcceso = true;
            Console.WriteLine($"[Lampadina] {Nome} in {Stanza} accesa (Luminosità: {Luminosita}%).");
        }

        public void Spegni()
        {
            IsAcceso = false;
            Console.WriteLine($"[Lampadina] {Nome} in {Stanza} spenta.");
        }
    }
}
