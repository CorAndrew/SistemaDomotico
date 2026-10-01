using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDomotico2
{
    public interface ISwitchable
    {
        void Accendi();
        void Spegni();
        bool IsAcceso { get; }
    }
}
