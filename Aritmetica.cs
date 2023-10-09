using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Tipo de conversão de temperatura a executar
    /// </summary>
    public enum ConversaoTemperatura
        { 
        Nulo = 0,
        CelsiuisFarenheit,
        FarenheitCelsius
        }
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal class Aritmetica
    {
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de dois números </returns>
        public int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números </returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiuisFarenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FarenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }
    }
}
