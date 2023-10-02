/* Objetivo: Converter uma máscara de sub-rede de decimal para binário e vice-versa.
 * Autor   : William Silva (github.com/unclWill)
 * Data    : 01/10/2023
 */

using System;
using System.Collections.Generic;

namespace CalcSubnet.Classes
{
    internal class EnderecoIP : Conversoes
    {
        private readonly FrmPrincipal formPrincipal;
        public EnderecoIP(FrmPrincipal frmPrincipal) 
        { 
            this.formPrincipal = frmPrincipal;
        }

        public EnderecoIP() { }

        protected override List<string> ConverterDecimalParaBinario(int octeto)
        {
            return base.ConverterDecimalParaBinario(octeto);
        }

        protected override int ConverterBinarioParaDecimal(string octeto)
        {
            return base.ConverterBinarioParaDecimal(octeto);
        }

        internal void ConverterIP()
        {
            if (formPrincipal.TipoDeConversaoIP == false)
            {
                try
                {
                    string[] enderecoDigitado = formPrincipal.TxtEnderecoIPDecimal.Split('.');
                    int[] enderecoIPv4 = Array.ConvertAll(enderecoDigitado, int.Parse);

                    List<string> octeto1 = new List<string>(), octeto2 = new List<string>(), octeto3 = new List<string>(), octeto4 = new List<string>();
                    string pOcteto = string.Empty, sOcteto = string.Empty, tOcteto = string.Empty, qOcteto = string.Empty;

                    int contOcteto = 0;
                    foreach (int octeto in enderecoIPv4)
                    {
                        contOcteto++;

                        switch (contOcteto)
                        {
                            case 1:
                                octeto1 = ConverterDecimalParaBinario(octeto);
                                pOcteto = string.Join("", octeto1);
                                break;
                            case 2:
                                octeto2 = ConverterDecimalParaBinario(octeto);
                                sOcteto = string.Join("", octeto2);
                                break;
                            case 3:
                                octeto3 = ConverterDecimalParaBinario(octeto);
                                tOcteto = string.Join("", octeto3);
                                break;
                            case 4:
                                octeto4 = ConverterDecimalParaBinario(octeto);
                                qOcteto = string.Join("", octeto4);
                                break;
                        }
                    }
                    formPrincipal.TxtEnderecoIPBinario = pOcteto + "." + sOcteto + "." + tOcteto + "." + qOcteto;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro!\n O campo endereço não pode estar vazio.");
                }
            }
            else if (formPrincipal.TipoDeConversaoIP == true)
            {
                try
                {
                    string[] enderecoDigitado = formPrincipal.TxtEnderecoIPBinario.Split('.');
                    int octeto1 = 0, octeto2 = 0, octeto3 = 0, octeto4 = 0;



                    int contOcteto = 0;
                    foreach (string octeto in enderecoDigitado)
                    {
                        contOcteto++;

                        switch (contOcteto)
                        {
                            case 1:
                                octeto1 = ConverterBinarioParaDecimal(octeto);
                                break;
                            case 2:
                                octeto2 = ConverterBinarioParaDecimal(octeto);
                                break;
                            case 3:
                                octeto3 = ConverterBinarioParaDecimal(octeto);
                                break;
                            case 4:
                                octeto4 = ConverterBinarioParaDecimal(octeto);
                                break;
                        }
                    }
                    formPrincipal.TxtEnderecoIPDecimal = octeto1.ToString() + "." + octeto2.ToString() + "." + octeto3.ToString() + "." + octeto4.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro!\n O campo endereço não pode estar vazio.");
                }
            }
        }

        internal void ResetarCamposIP()
        {
            const string valorPadraoDecimal = "0.0.0.0";
            const string valorPadraoBinario = "00000000.00000000.00000000.00000000";

            formPrincipal.TxtEnderecoIPDecimal = valorPadraoDecimal;
            formPrincipal.TxtEnderecoIPBinario = valorPadraoBinario;
        }
    }
}
