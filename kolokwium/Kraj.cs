using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Kraj:IComparable<Kraj>
    {
        private string nazwa;
        private int powierzchnia;

        private Kraj(string nazwa, int powierzchnia)
        {
            this.nazwa = nazwa;
            this.powierzchnia = powierzchnia;
        }
        static public Kraj UtworzKraj(string nazwa, int powierzhcnia)
        {
            Kraj kraj = new Kraj(nazwa, powierzhcnia);
            return kraj;
        }
        public override string ToString()
        {
            return "Kraj: " + nazwa + ", powierzchnia: " + powierzchnia;
        }

        public int CompareTo(Kraj other)
        {
            if (powierzchnia == other.powierzchnia)
            {
                return nazwa.CompareTo(other.nazwa);
            }
            else
            {
                return powierzchnia.CompareTo(other.powierzchnia);
            }
        }
    }
}
