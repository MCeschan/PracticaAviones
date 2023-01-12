using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAviones
{
    public abstract class AvionCarga : Avion
    {
        public int Peso { get; set; }
        public string TipoMercaderia { get; set; }
        public AvionCarga(string Piloto, string Copiloto, string Azafata, int Peso, string TipoMercaderia) : base(Piloto, Copiloto, Azafata)
        {
            this.Peso = Peso;
            this.TipoMercaderia = TipoMercaderia;
        }
    }
}
