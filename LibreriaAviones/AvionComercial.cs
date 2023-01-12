using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAviones
{
    public class AvionComercial : Avion
    {
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }
        public AvionComercial(string Piloto, string Copiloto, string Azafata, int Capacidad, string LineaAerea) : base(Piloto, Copiloto, Azafata)
        {
            this.Capacidad = Capacidad;
            this.LineaAerea = LineaAerea;
        }
        public override string Aterriza()
        {
            return "El avión aterriza a las 20hs";
        }
        public override string Despega()
        {
            return "El avión despega a las 10hs";
        }
        public override string ToString()
        {
            return VerPropiedades() + " La Capacidad es " + Capacidad.ToString() + ". La línea aérea es " + LineaAerea;
        }
    }
}
