using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Esta classe implementa operações de conversão
    /// </summary>
    internal static class conversoes
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
        /// Tipo de conversão de distâncias
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }
        /// <summary>
        /// Conversão de temperaturas
        /// </summary>
        /// <param name="conversao">A conversão a efectuar</param>
        /// <param name="temperatura">Temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
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
        /// <summary>
        /// Conversão de distâncias
        /// </summary>
        /// <param name="conversao">A conversão a efectuar</param>
        /// <param name="distancia">A distância a converter</param>
        /// <returns>O resultado da conversão da distância</returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }

            return -1;
        }
    }
}
