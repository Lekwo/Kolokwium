using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Stolica
    {
        private string nazwa;
        private bool lotnisko;

        public Stolica(string nazwa, bool lotnisko)
        {
            this.nazwa = nazwa;
            this.lotnisko = lotnisko;
        }

        public override string ToString()
        {
            if (lotnisko == true)
            {
                return "Stolica: " + nazwa + ", lotnisko: tak";
            }
            else
            {
                return "Stolica: " + nazwa + ", lotnisko: nie";
            }
            
        }
    }
}
