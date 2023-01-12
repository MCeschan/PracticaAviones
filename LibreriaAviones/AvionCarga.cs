using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAviones
{
    public class AvionCarga : Avion
    {
        public int Peso { get; set; }
        public string TipoMercaderia { get; set; }
        public AvionCarga(string Piloto, string Copiloto, string Azafata, int Peso, string TipoMercaderia) : base(Piloto, Copiloto, Azafata)
        {
            this.Peso = Peso;
            this.TipoMercaderia = TipoMercaderia;
        }
        public override string Aterriza()
        {
            return "El avión aterriza a las 10hs";
        }
        public override string Despega()
        {
            return "El avión despega a las 4hs";
        }
    }
}
