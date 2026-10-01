using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomotico2
{
    public class Allarme : ISwitchable
    {
        public bool IsAcceso { get; private set; }

        public Allarme()
        {
            IsAcceso = false;
        }

        public void Accendi()
        {
            IsAcceso = true;
        }

        public void Spegni()
        {
            IsAcceso = false;
        }
    }
}
