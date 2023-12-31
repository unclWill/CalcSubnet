﻿/* Objetivo: Converter um endereço IP de decimal para binário e vice-versa.
 * Autor   : William Silva (github.com/unclWill)
 * Data    : 01/10/2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;

namespace CalcSubnet.Classes
{
    internal class Mascara : Conversoes
    {
        private readonly FrmPrincipal formPrincipal;

        public Mascara(FrmPrincipal frmPrincipal)
        {
            this.formPrincipal = frmPrincipal;
        }

        public Mascara() { }

        /// <summary>
        /// Monta a máscara de sub-rede binária em tempo real, de acordo com o valor inserido no campo CIDR na definição do endereço IPv4.
        /// </summary>
        /// <param name="qtdDigitos1">Quantidade de dígitos 1, referentes à porção de rede.</param>
        /// <returns>Retorna a máscara binária com a quantidade de dígitos 1 equivalente ao campo CIDR.</returns>
        internal string InserirDigitosBin(int qtdDigitos1)
        {
            const int qtdDeBits = 32;
            StringBuilder gerarMascara = new StringBuilder(qtdDeBits);

            for (int i = 0; i < qtdDeBits; i++)
            {
                if (i < qtdDigitos1)
                {
                    gerarMascara.Append('1');
                }
                else
                {
                    gerarMascara.Append('0');
                }

                if ((i + 1) % 8 == 0 && i < qtdDeBits - 1)
                {
                    gerarMascara.Append('.');
                }
            }

            return gerarMascara.ToString();
        }

        protected override List<string> ConverterDecimalParaBinario(int octeto)
        {
            return base.ConverterDecimalParaBinario(octeto);
        }

        protected override int ConverterBinarioParaDecimal(string octeto)
        {
            return base.ConverterBinarioParaDecimal(octeto);
        }

        internal void ConverterMascaraDecimalParaBinario(sbyte tipoAcao = 1)
        {
            try
            {
                string[] enderecoDigitado = formPrincipal.TxtMascaraDecimal.Trim().Split('.');
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
                                octeto2 = ConverterDecimalParaBinario(octeto); ;
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

                    formPrincipal.TxtMascaraBinario = pOcteto + "." + sOcteto + "." + tOcteto + "." + qOcteto;
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
                                octeto2 = ConverterDecimalParaBinario(octeto); ;
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

                    formPrincipal.TxtCIDRMascaraDecimal = DeterminarCIDR(pOcteto, sOcteto, tOcteto, qOcteto).ToString();
                    formPrincipal.TxtMascaraBinario = pOcteto + "." + sOcteto + "." + tOcteto + "." + qOcteto;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!\n O campo endereço não pode estar vazio.");
            }
        }

        internal void ConverterMascaraBinarioParaDecimal(sbyte tipoAcao = 1)
        {
            try
            {
                string[] enderecoDigitado = formPrincipal.TxtMascaraBinario.Trim().Split('.');
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

                    DeterminarQtdSubredes(enderecoDigitado);

                    formPrincipal.TxtMascaraDecimal = octeto1.ToString() + "." + octeto2.ToString() + "." + octeto3.ToString() + "." + octeto4.ToString();
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

                    DeterminarCIDR(enderecoDigitado);

                    formPrincipal.TxtMascaraDecimal = octeto1.ToString() + "." + octeto2.ToString() + "." + octeto3.ToString() + "." + octeto4.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro!\n O campo máscara não pode estar vazio.");
            }
        }

        // Determina o CIDR com base na união dos octetos. Utilizado na conversão DEC para BIN.
        private int DeterminarCIDR(string octeto1, string octeto2, string octeto3, string octeto4)
        {
            string tamanhoSubrede = octeto1 + octeto2 + octeto3 + octeto4;

            int qtd1s = 0;

            for (int i = 0; i < tamanhoSubrede.Length; i++)
            {
                char carac1 = '1';

                if (tamanhoSubrede[i] == carac1)
                {
                    qtd1s++;
                }
                else
                {
                    break;
                }
            }

            return qtd1s;
        }

        // Determina o CIDR com base no array lido. Utilizado na conversão BIN para DEC.
        private int DeterminarCIDR(string[] mascara)
        {
            string tamanhoSubrede = string.Join("", mascara);

            int qtd1s = 0;

            for (int i = 0; i < tamanhoSubrede.Length; i++)
            {
                char carac1 = '1';

                if (tamanhoSubrede[i] == carac1)
                {
                    qtd1s++;
                }
                else
                {
                    break;
                }
            }

            return qtd1s;
        }

        private void DeterminarQtdSubredes(string[] endereco)
        {
            string octetoMisto = string.Empty;

            // Verifica cada octeto até encontrar um que contenha os bits 1 e 0 (no mesmo octeto) e utiliza esse octeto mesclado para a operção.
            for (int i = 0; i < endereco.Length; i++)
            {
                if (endereco[i].Contains('0'))
                {
                    octetoMisto = endereco[i];
                    break;
                }
            }

            // Conta a quantidade de dígitos 0 no restante da máscara.
            byte qtdBitsDeHost = 0;
            byte qtdBitsDeRede = 0;

            for (int k = 0; k < endereco.Length; k++)
            {
                string octeto = endereco[k];

                for (int l = 0; l < octeto.Length; l++)
                {
                    if (octeto[l] == '0')
                    {
                        qtdBitsDeHost++;
                    }
                    else 
                    {
                        qtdBitsDeRede++;
                    }

                }
            }

            byte qtdDigitos1 = 0;
            byte qtdDigitos0 = 0;

            for (int j = 0; j < octetoMisto.Length; j++)
            {
                if (octetoMisto[j] == '1')
                {
                    qtdDigitos1++;
                }
                else
                {
                    qtdDigitos0++;
                }
            }

            byte cidr = byte.Parse(formPrincipal.TxtCIDRMascaraDecimal);
            long qtdDeSubredes = 0;

            if (cidr >= 1 && cidr <= 16)
            {
                qtdDeSubredes = (long)Math.Pow(2, qtdDigitos1);
            }
            else if (cidr >= 1 && cidr <= 23)
            {
               qtdDeSubredes = (long)Math.Pow(2, qtdDigitos1 + 8);
            }
            else if (cidr >= 24)
            {
                qtdDeSubredes = (long)Math.Pow(2, qtdDigitos1 + 16);
            }

            //long qtdDeSubredes = (long)Math.Pow(2, qtdDigitos1);
            //
            long qtdHostsPorSubRede = (long)Math.Pow(2, qtdBitsDeHost) - 2;
            //

            long qtdHostsPossiveis = (long)Math.Pow(2, qtdBitsDeHost);

            formPrincipal.TxtQtdDeSubredes = qtdDeSubredes.ToString("N1");
            formPrincipal.TxtQtdDeHosts = qtdHostsPorSubRede.ToString("N1");
            formPrincipal.TxtQtdHostsPossiveisPorSubrede = qtdHostsPossiveis.ToString("N1");
            //
            formPrincipal.TxtEnderecoDeRede = formPrincipal.TxtEnderecoIPDecimal.ToString();
        }

        internal void ResetarCamposMascara()
        {
            const string valorPadraoDecimal = "0.0.0.0";
            const string valorPadraoBinario = "00000000.00000000.00000000.00000000";
            const string valorPadraoCIDR = "0";
            //
            const string valorPadraoClasseIP = "INDF";
            const string valorPadraoResultados = "0";

            formPrincipal.TxtMascaraDecimal = valorPadraoDecimal;
            formPrincipal.TxtMascaraBinario = valorPadraoBinario;
            formPrincipal.TxtCIDRMascaraDecimal = valorPadraoCIDR;
            //
            formPrincipal.TxtClasseDoIP = valorPadraoClasseIP;
            //formPrincipal.TxtClasseDoIPCor.BackColor = Color.White;
            formPrincipal.TxtQtdDeSubredes = valorPadraoResultados;
            formPrincipal.TxtQtdDeHosts = valorPadraoResultados;
            formPrincipal.TxtQtdHostsPossiveisPorSubrede = valorPadraoResultados;
            formPrincipal.TxtExibirMensagens = "Todos os campos foram resetados para os valores padrão.";
        }
    }
}
