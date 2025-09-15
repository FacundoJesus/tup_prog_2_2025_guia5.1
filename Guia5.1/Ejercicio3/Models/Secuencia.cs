using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Secuencia
    {
        public string SecuenciaEntrada { get; private set; }

        public bool Verificada;

        public Secuencia(string secuenciaEntrada)
        {
            this.SecuenciaEntrada = secuenciaEntrada;
        }

        public virtual void ProcesarCadena()
        {
            this.Verificada = true;
        }
    }
}
