using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomoticoP1
{
    public class Termostato
    {
        public string Nome { get; set; }
        public string Stanza { get; set; }
        public double Temperatura { get; set; }
        public bool IsAcceso { get; private set; }

        public Termostato(string nome, string stanza, double temperatura)
        {
            Nome = nome;
            Stanza = stanza;
            Temperatura = temperatura;
            IsAcceso = false;
        }

        public void Accendi()
        {
            IsAcceso = true;
            Console.WriteLine($"[Termostato] {Nome} in {Stanza} acceso (Temperatura target: {Temperatura}°C).");
        }

        public void Spegni()
        {
            IsAcceso = false;
            Console.WriteLine($"[Termostato] {Nome} in {Stanza} spento.");
        }
    }
}
