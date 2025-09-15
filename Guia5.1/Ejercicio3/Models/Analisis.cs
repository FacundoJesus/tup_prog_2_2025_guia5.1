using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class Analisis
    {
        public int CantidadSecuencia { 
            get
            {
                return listasecuencias.Count;
            }
        }

        private List <Secuencia> listasecuencias = new List <Secuencia>();

        public void AgregarSecuencia(string secuencia)
        {
            
         
        }

        public Secuencia VerSecuencia(int idx)
        {
            if (idx >= 0 && idx < listasecuencias.Count) { 
                return listasecuencias[idx] as Secuencia;
            }
            return null;
        }
    }
}
