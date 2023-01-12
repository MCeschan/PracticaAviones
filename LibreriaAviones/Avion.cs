using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAviones
{
    public abstract class Avion
    {
        public Avion(string Piloto, string Copiloto, string Azafata)
        {
            this.Piloto = Piloto;
            this.Copiloto = Copiloto;
            this.Azafata = Azafata;
        }
        public abstract string Aterriza();
        public abstract string Despega();
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }
    }
}
