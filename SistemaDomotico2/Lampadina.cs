using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomotico2
{
    public class Lampadina : DispositivoSmart
    {
        public int Luminosita { get; set; }

        public Lampadina(string nome, string stanza, int luminosita)
            : base(nome, stanza)
        {
            Luminosita = luminosita;
        }

        public override string MostraDettagli()
        {
            string stato = IsAcceso ? "Accesa" : "Spenta";
            return $"[Lampadina] {Nome} ({Stanza}) | Stato: {stato} | Luminosità: {Luminosita}%";
        }
    }
}
