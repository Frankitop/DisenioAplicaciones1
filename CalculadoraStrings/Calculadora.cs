using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraStrings
{
    public class Calculadora
    {
        private const int ValorPorDefecto = 0;
        private const string Separador = ",";

        public object Sumar(string numeros)
        {
            if (EsSoloUnNumero(numeros))
            {
                return ConvertirStringAInt(numeros);
            }

            if (SonVariosNumeros(numeros))
            {
                string[] valores = numeros.Split(ConvertirSeparador());
                return ConvertirStringAInt(valores[0]) + ConvertirStringAInt(valores[1]);
            }

            return ValorPorDefecto;
        }

        private static char ConvertirSeparador()
        {
            return Separador.ToCharArray().First();
        }

        private static bool SonVariosNumeros(string numeros)
        {
            return numeros.Contains(Separador);
        }

        private static int ConvertirStringAInt(string numeros)
        {
            return int.Parse(numeros);
        }

        private static bool EsSoloUnNumero(string numeros)
        {
            return numeros.Length == 1;
        }
    }
}
