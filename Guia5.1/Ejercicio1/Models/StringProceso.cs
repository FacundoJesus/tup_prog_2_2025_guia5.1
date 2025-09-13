using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class StringProceso : IProceso
    {
        public string Procesar(string patente)
        {

            //Limpio la Patente para trabajar solo con los números.
            string patenteSinEspacios = patente.Replace(" ", "").Replace("-", "").ToUpper();


            #region CASO 1º Automóviles y camionetas hasta 2016
            // Ej. Correcto: OXY333
            bool isHasta2016 = patenteSinEspacios.Length == 6;

            for (int n = 0; n < patenteSinEspacios.Length && isHasta2016 == true; n++)
            {
                char d = patenteSinEspacios[n];
                isHasta2016 = isHasta2016 && (char.IsLetter(d) && n < 3) || (char.IsNumber(d) && n < 6 && n >= 3);
            }
            if (isHasta2016 == true)
            {   
                return "Automóviles y camionetas hasta 2016";
            }
            #endregion


            #region CASO 2º Automóviles y camionetas desde 2016
            // Ej. Correcto: OX333AL
            bool isDesde2016 = patenteSinEspacios.Length == 7;

            for (int n = 0; n < patenteSinEspacios.Length && isDesde2016 == true; n++)
            {
                char d = patenteSinEspacios[n];
                isDesde2016 = isDesde2016 && (char.IsLetter(d) && n < 2) || (char.IsNumber(d) && n < 5 && n >= 2) || (char.IsLetter(d) && n < 7 && n >= 5);
            }

            if (isDesde2016 == true)
            {
                return "Automóviles y camionetas desde 2016";
            }
            #endregion


            #region CASO 3º Motocicleta
            // Ej. Correcto: AA123AAA
            bool esMoto = patenteSinEspacios.Length == 8;
            for(int i = 0; i<patenteSinEspacios.Length && esMoto==true;i++)
            {
                char d = patenteSinEspacios[i];
                esMoto = esMoto && (char.IsLetter(d) && i < 2) || (char.IsNumber(d) && i < 5 && i >=2) || (char.IsLetter(d) && i < 8 && i >= 5);
            }
            if(esMoto)
            {
                return "Motocicleta";
            }
            #endregion


            #region CASO 4º Acoplado
            //Ej.Correcto: AA1234
            bool esAcoplado = patenteSinEspacios.Length == 6;
            for(int i = 0; i<patenteSinEspacios.Length && esAcoplado==true; i++)
            {
                char d = patenteSinEspacios[i];
                esAcoplado = esAcoplado && (char.IsLetter(d) && i < 2) || (char.IsNumber(d) && i >= 2 && i < 6);
            }
            if(esAcoplado==true) {
                return "Acoplado";
            }
            #endregion


            #region CASO 5º Otro
            return "Otro";
            #endregion

        }
    }
}          
