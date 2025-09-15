using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Proteina
    {
        public string Secuencia { get; set; }
        public Proteina(string secuencia)
        {
            this.Secuencia = secuencia;
        }

        Aminoacido aminoacido;
        public void AgregarAminoacido(string secuencia)
        {
            aminoacido = new Aminoacido();
            aminoacido.Descripcion();
        }
    }
}
