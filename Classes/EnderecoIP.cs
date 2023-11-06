/* Objetivo: Converter uma máscara de sub-rede de decimal para binário e vice-versa.
 * Autor   : William Silva (github.com/unclWill)
 * Data    : 01/10/2023
 */

using System;
using System.Collections.Generic;
using System.Text;

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

        internal void ConverterIPDecimalParaBinario(sbyte tipoAcao = 1)
        {
            try
            {               
                string[] enderecoDigitado = formPrincipal.TxtEnderecoIPDecimal.Split('.');
                int[] enderecoIPv4 = Array.ConvertAll(enderecoDigitado, int.Parse);

                List<string> octeto1 = new List<string>(), octeto2 = new List<string>(), octeto3 = new List<string>(), octeto4 = new List<string>();
                string pOcteto = string.Empty, sOcteto = string.Empty, tOcteto = string.Empty, qOcteto = string.Empty;

                if (tipoAcao == 1)
                {
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
                    formPrincipal.TxtClasseDoIP = DeterminarClasseDoIP(enderecoDigitado);
                }
                else
                {
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

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!\n O campo endereço não pode ficar vazio.");
            }
        }

        internal void ConverterIPBinarioParaDecimal(sbyte tipoAcao = 1)
        {
            try
            {
                string[] enderecoDigitado = formPrincipal.TxtEnderecoIPBinario.Split('.');
                int octeto1 = 0, octeto2 = 0, octeto3 = 0, octeto4 = 0;

                if (tipoAcao == 1)
                {
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
                    formPrincipal.TxtClasseDoIP = DeterminarClasseDoIP(enderecoDigitado);
                }
                else
                {
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!\n O campo endereço não pode ficar vazio.");
            }
        }

        internal string DeterminarClasseDoIP(string[] enderecoIP)
        {
            int[] enderecoConvertido = Array.ConvertAll(enderecoIP, int.Parse);

            const string classeA = "A", classeB = "B", classeC = "C", classeD = "D", classeE = "E", classeIndefinida = "INDF";
            StringBuilder mensagens = new StringBuilder();

            int octeto1 = enderecoConvertido[0];

            if ((octeto1 >= 1) && (octeto1 <= 127))
            {
                // Popular o campo máscara padrão.
                formPrincipal.TxtMascaraDecimal = "255.0.0.0";
                // Mensagem.
                formPrincipal.TxtExibirMensagens = mensagens.Append("O endereço pertence à classe A.").ToString();
                // Retorno.
                return (classeA);
            }
            else if ((octeto1 >= 128) && (octeto1 <= 191))
            {
                // Popular o campo máscara padrão.
                formPrincipal.TxtMascaraDecimal = "255.255.0.0";
                // Mensagem.
                formPrincipal.TxtExibirMensagens = mensagens.Append("O endereço pertence à classe B.").ToString();
                // Retorno.
                return classeB;
            }
            else if ((octeto1 >= 192) && (octeto1 <= 223))
            {
                // Popular o campo máscara padrão.
                formPrincipal.TxtMascaraDecimal = "255.255.255.0";
                // Mensagem.
                formPrincipal.TxtExibirMensagens = mensagens.Append("O endereço pertence à classe C.").ToString();
                // Retorno.
                return classeC;
            }
            else if ((octeto1 >= 224) && (octeto1 <= 239))
            {
                // Mensagem.
                formPrincipal.TxtExibirMensagens = mensagens.Append("Esta classe é utilizada para Multicasting.").ToString();
                // Retorno.
                return classeD;
            }
            else if ((octeto1 >= 240) && (octeto1 <= 255))
            {
                // Mensagem.
                formPrincipal.TxtExibirMensagens = mensagens.Append("Esta classe é experimental.").ToString();
                return classeE;
            }
            else
            {
                // Mensagem.
                formPrincipal.TxtExibirMensagens = mensagens.Append("Nenhum endereço IP válido foi definido.").ToString();
                // Retorno.
                return classeIndefinida;
            }
        }

        internal void ResetarCamposIP()
        {
            const string valorPadraoDecimal = "0.0.0.0";
            const string valorPadraoBinario = "00000000.00000000.00000000.00000000";
            const string valorPadraoCIDR = "0";

            formPrincipal.TxtEnderecoIPDecimal = valorPadraoDecimal;
            formPrincipal.TxtEnderecoIPBinario = valorPadraoBinario;
            formPrincipal.TxtCIDREnderecoIPDecimal = valorPadraoCIDR;
        }
    }
}
