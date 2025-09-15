using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Intimacion
    {
        public string LugarEmision { get; set; }
        public DateTime FechaEmision { get; set; }
        public string PersonaDemandada { get; set; }
        public string EstudioJuridicoDemandante { get; set; }
        public string PersonaDemandante { get; set; }
        public DateTime FechayHoraEjecucion { get; set; }
        public double MontoAdeudado { get; set; }

        public string[] ToString()
        {
            string[]resumen = new string[7];
            int i = 0;
            resumen[i++] = $"Lugar de Emisión: {LugarEmision}";
            resumen[i++] = $"Fecha de Emisión: {FechaEmision}";
            resumen[i++] = $"Persona Demandada: {PersonaDemandada}";
            resumen[i++] = $"Estudio Jurídico Demandante: {EstudioJuridicoDemandante}";
            resumen[i++] = $"Persona Demandante: {PersonaDemandante}";
            resumen[i++] = $"Fecha y Hora de Ejecución: {FechayHoraEjecucion}";
            resumen[i++] = $"Monto Adeudado: {MontoAdeudado:c2} ";
            
            return resumen;
        }
    }
}
