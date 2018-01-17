using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    interface ISprawdzanie:IOperacje
    {
        bool Sprawdz(string a);
    }
}
