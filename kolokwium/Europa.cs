using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Europa:ISprawdzanie
    {
        private SortedList<Kraj, Stolica> panstwa = new SortedList<Kraj,Stolica>();

        public void Dodaj(string kraj, int powierzchnia, string stolica, bool lotnisko)
        {
            panstwa.Add(Kraj.UtworzKraj(kraj, powierzchnia), new Stolica(stolica, lotnisko));
        }

        public bool Sprawdz(string a)
        {
            throw new NotImplementedException();
        }
        public void Usun()
        {
            throw new NotImplementedException();
        }

        public void Usun(string kraj)
        {
            throw new NotImplementedException();
        }
    }
}
