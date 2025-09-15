using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class RegexProceso : IProceso
    {
        public Intimacion ProcesarDatos(string texto)
        {
            Intimacion intimacion = new Intimacion();

            Match match = null;
            Regex regex = null;


            #region Extraigo el Lugar de Emision
            regex = new Regex(@"^\s+\w*");
            match = regex.Match(texto);
            if(match.Success)
            {
                intimacion.LugarEmision= match.Value.Trim();
            }
            #endregion


            #region Extraigo la Fecha de Emisión
            regex = new Regex(@"(\d{1,2}) de ([a-zA-Z]+) de (\d{4})", RegexOptions.IgnoreCase);
            match = regex.Match(texto);
            if(match.Success) {
                int dia = Convert.ToInt32(match.Groups[1].Value.Trim());
                string mesEnString = match.Groups[2].Value.ToUpper().Trim();
                int ano = Convert.ToInt32(match.Groups[3].Value.Trim());

                int mes = 0;
                switch (mesEnString)
                {
                    case "ENERO": { mes = 1; } break;
                    case "FEBRERO": { mes = 2; } break;
                    case "MARZO": { mes = 3; } break;
                    case "ABRIL": { mes = 4; } break;
                    case "MAYO": { mes = 5; } break;
                    case "JUNIO": { mes = 6; } break;
                    case "JULIO": { mes = 7; } break;
                    case "AGOSTO": { mes = 8; } break;
                    case "SEPTIEMBRE": { mes = 9; } break;
                    case "OCTUBRE": { mes = 10; } break;
                    case "NOVIEMBRE": { mes = 11; } break;
                    case "DICIEMBRE": { mes = 12; } break;
                }

                intimacion.FechaEmision = new DateTime(ano,mes,dia);
            }
            #endregion


            #region Extraigo la Persona Demandada
            regex = new Regex(@"(Sr\(a\)) ([ a-zA-Záéíóú]+)");
            match = regex.Match(texto);
            if (match.Success) {
                intimacion.PersonaDemandada = match.Groups[2].Value;
            }
            #endregion


            #region Extraigo Estudio Jurídico Demandante
            regex = new Regex(@"(JURÍDICO\s+GUTIERREZ\s+&\s+ASOCIADOS),\s*mediante", RegexOptions.IgnoreCase);
            match = regex.Match(texto);
            if(match.Success) {
                intimacion.EstudioJuridicoDemandante = match.Groups[1].Value.Trim();
            }
            #endregion


            #region Extraigo la Persona Demandante
            regex = new Regex(@"(corporativo) ([ a-zA-Záéíóú]+)");
            
            match = regex.Match(texto);
            if(match.Success)
            {
                intimacion.PersonaDemandante = match.Groups[2].Value.Trim();
            }
            #endregion


            #region Extraigo la Fecha y Hora de Ejecucion
            Regex regexFecha = new Regex(@"(\d{1,2}) de ([a-zA-Záéíóúñ]+) de (\d{4})", RegexOptions.IgnoreCase);
            Regex regexHora = new Regex(@"a las\s+(\d{1,2}):(\d{2})", RegexOptions.IgnoreCase);

            Match matchFecha = regexFecha.Match(texto);
            Match matchHora = regexHora.Match(texto);

            if (matchFecha.Success && matchHora.Success)
            {
                int dia = Convert.ToInt32(matchFecha.Groups[1].Value.Trim());
                string mesEnString = matchFecha.Groups[2].Value.Trim();
                int anio = Convert.ToInt32(matchFecha.Groups[3].Value.Trim());

                int mes = 0;
                switch (mesEnString)
                {
                    case "ENERO": { mes = 1; } break;
                    case "FEBRERO": { mes = 2; } break;
                    case "MARZO": { mes = 3; } break;
                    case "ABRIL": { mes = 4; } break;
                    case "MAYO": { mes = 5; } break;
                    case "JUNIO": { mes = 6; } break;
                    case "JULIO": { mes = 7; } break;
                    case "AGOSTO": { mes = 8; } break;
                    case "SEPTIEMBRE": { mes = 9; } break;
                    case "OCTUBRE": { mes = 10; } break;
                    case "NOVIEMBRE": { mes = 11; } break;
                    case "DICIEMBRE": { mes = 12; } break;
                }

                int hora = Convert.ToInt32(matchHora.Groups[1].Value.Trim());
                int minutos = Convert.ToInt32(matchHora.Groups[2].Value.Trim());

           
                intimacion.FechayHoraEjecucion = new DateTime(anio, mes, dia, hora, minutos, 0);
            }
            #endregion

            #region Extraigo el Monto Adeudado
            regex = new Regex(@"\s(\$[\d\.,]+)\s*\(");
            match = regex.Match(texto);
            if (match.Success)
            {
                string monto = match.Groups[1].Value.Trim();
                // quitar el signo $
                monto = monto.Replace("$", "");

                // quitar separador de miles
                monto = monto.Replace(".", "");

                // usar coma como decimal
                monto = monto.Replace(",", ".");

                double montoFinal = Convert.ToDouble(monto, System.Globalization.CultureInfo.InvariantCulture);
                intimacion.MontoAdeudado = montoFinal;
            }
            #endregion

            return intimacion;
        }
    }
}
