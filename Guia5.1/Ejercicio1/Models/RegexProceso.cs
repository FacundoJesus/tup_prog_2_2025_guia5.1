using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RegexProceso : IProceso
    {
        
        public string Procesar(string patente)
        {
            //Limpio la Patente para trabajar solo con los números.
            string patenteSinEspacios = patente.Replace(" ", "").Replace("-", "").ToUpper();

            #region CASO 1º Automóviles y camionetas hasta 2016
            // Ej. Correcto: OXY 333
            Regex regex = new Regex(@"^[A-Za-z]{3}\d{3}$");
            Match match = regex.Match(patenteSinEspacios);
            if (match.Success) {
                return "Automóviles y camionetas hasta 2016";
            }
            #endregion


            #region CASO 2º Automóviles y camionetas desde 2016
            // Ej. Correcto: AA 123 AD
            regex = new Regex(@"^[A-Za-z]{2}\d{3}[A-Za-z]{2}$");
            match = regex.Match(patenteSinEspacios);
            if (match.Success)
            {
                return "Automóviles y camionetas desde 2016";
            }
            #endregion


            #region CASO 3º Motocicleta
            // Ej. Correcto: AA 123 ADA
            regex = new Regex(@"^[A-Za-z]{2}\d{3}[A-Za-z]{3}$");
            match = regex.Match(patenteSinEspacios);
            if (match.Success)
            {
                return "Motocicleta";
            }
            #endregion

            #region CASO 4º Acoplado
            // Ej. Correcto: AA 1234
            regex = new Regex(@"^[A-Za-z]{2}\d{4}$");
            match = regex.Match(patenteSinEspacios);
            if (match.Success)
            {
                return "Acoplado";
            }
            #endregion

            #region CASO 5º Otro
            return "Otro";
            #endregion
        }
    }
}
