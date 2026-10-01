using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomotico2
{
    public abstract class DispositivoSmart : ISwitchable
    {
        public string Nome { get; set; }
        public string Stanza { get; set; }
        public bool IsAcceso { get; protected set; }

        public DispositivoSmart(string nome, string stanza)
        {
            Nome = nome;
            Stanza = stanza;
            IsAcceso = false;
        }

        public virtual void Accendi()
        {
            IsAcceso = true;
        }

        public virtual void Spegni()
        {
            IsAcceso = false;
        }

        // Restituisce le informazioni sotto forma di stringa
        public abstract string MostraDettagli();
    }
}
