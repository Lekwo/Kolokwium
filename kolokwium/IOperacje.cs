using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    interface IOperacje
    {
        void Dodaj(string kraj, int powierzchnia, string stolica, bool lotnisko);
        void Usun();
        void Usun(string kraj);
    }
}
