using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomotico2
{
    public class Termostato : DispositivoSmart
    {
        public double Temperatura { get; set; }

        public Termostato(string nome, string stanza, double temperatura)
            : base(nome, stanza)
        {
            Temperatura = temperatura;
        }

        public override string MostraDettagli()
        {
            string stato = IsAcceso ? "Acceso" : "Spento";
            return $"[Termostato] {Nome} ({Stanza}) | Stato: {stato} | Temp: {Temperatura}°C";
        }
    }
}
