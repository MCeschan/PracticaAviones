using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAviones
{
    public abstract class AvionComercial : Avion
    {
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }
        public AvionComercial(string Piloto, string Copiloto, string Azafata, int Capacidad, string LineaAerea) : base(Piloto, Copiloto, Azafata)
        {
            this.Capacidad = Capacidad;
            this.LineaAerea = LineaAerea;
        }
    }
}
