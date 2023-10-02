/* Objetivo: Realizar as conversões entre as bases decimal e binária.
 * Autor   : William Silva (github.com/unclWill)
 * Data    : 01/10/2023
 */

using System;
using System.Collections.Generic;

namespace CalcSubnet.Classes
{
    internal class Conversoes
    {
        protected virtual List<string> ConverterDecimalParaBinario(int octeto)
        {
            string octetoBin = Convert.ToString(octeto, 2).PadLeft(8, '0');
            List<string> digitosBinarios = new List<string>();

            foreach (char bit in octetoBin)
            {
                digitosBinarios.Add(bit.ToString());
            }

            return digitosBinarios;
        }

        protected virtual int ConverterBinarioParaDecimal(string octeto)
        {
            int octetoDec = Convert.ToInt32(octeto, 2);
            return octetoDec;
        } 
    }
}
