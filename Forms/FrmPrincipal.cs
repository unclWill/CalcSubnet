using System;
using System.Diagnostics;
using System.Drawing.Configuration;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CalcSubnet.Classes;
using CalcSubnet.Forms;

namespace CalcSubnet
{
    public partial class FrmPrincipal : Form
    {
        private static bool tipoDeConversaoIP = false; // Decimal para Binário (valor padrão)
        private static bool tipoDeConversaoMascara = false; // Decimal para Binário (valor padrão)

        #region Propriedades dos estados dos RadioButtons de tipo de conversão
        public bool TipoDeConversaoIP
        {
            get => tipoDeConversaoIP;
        }

        public bool TipoDeConversaoMascara
        {
            get => tipoDeConversaoMascara;
        }
        #endregion

        #region Propriedades dos TextBoxes de conversão de IP
        public string TxtEnderecoIPDecimal
        {
            get => TxtEnderecoIPDec.Text;
            set => TxtEnderecoIPDec.Text = value;
        }

        public string TxtEnderecoIPBinario
        {
            get => TxtEnderecoIPBin.Text;
            set => TxtEnderecoIPBin.Text = value;
        }
        #endregion

        #region Propriedades dos TextBoxes de conversão de Máscara
        public string TxtMascaraDecimal
        {
            get => TxtMascaraDec.Text;
            set => TxtMascaraDec.Text = value;
        }

        public string TxtMascaraBinario
        {
            get => TxtMascaraBin.Text;
            set => TxtMascaraBin.Text = value;
        }
        #endregion

        #region Propriedades dos TextBoxes que exibem os resultados em quantidades.
        public string TxtClasseDoIP
        {
            get => TxtClasseIP.Text;
            set => TxtClasseIP.Text = value;
        }

        public TextBox TxtClasseDoIPCor
        {
            //get => TxtClasseIP.BackColor = Color.PaleGreen;
            set => TxtClasseIP.BackColor = value.BackColor;
        }

        public string TxtQtdDeSubredes
        {
            get => TxtQtdSubredes.Text;
            set => TxtQtdSubredes.Text = value;
        }

        public string TxtQtdDeHosts
        {
            get => TxtQtdHosts.Text;
            set => TxtQtdHosts.Text = value;
        }

        public string TxtQtdHostsPossiveisPorSubrede
        {
            get => TxtQtdHostsPossiveis.Text;
            set => TxtQtdHostsPossiveis.Text = value;

        }
        #endregion

        #region Propriedades dos TextBoxes que exibem o CIDR.
        public string TxtCIDREnderecoIPDecimal
        {
            get => TxtCIDREndIP.Text;
            set => TxtCIDREndIP.Text = value;
        }

        public string TxtCIDRMascaraDecimal
        {
            get => TxtCIDRMasc.Text;
            set => TxtCIDRMasc.Text = value;
        }
        #endregion

        #region Propriedades da caixa de mensagens
        public string TxtExibirMensagens
        {
            get => RtxtMensagens.Text;
            set => RtxtMensagens.Text = value;
        }

        public string TxtEnderecoDeRede
        {
            get => TxtEnderecoIPDeRede.Text;
            set => TxtEnderecoIPDeRede.Text = value;
        }

        public string TxtEnderecoDeBroadcast
        {
            get => TxtEnderecoIPDeBroadcast.Text;
            set => TxtEnderecoIPDeBroadcast.Text = value;
        }
        #endregion

        public FrmPrincipal()
        {
            InitializeComponent();
            Text = Program.ExibirVersao();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SelTipoConversaoIP();
            SelTipoConversaoMascara();
            HabilitarBotaoCalcular();
        }

        #region Eventos do Menu
        private void MnuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerra agora?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MnuCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Desculpe, mas este recurso não pode ser acessado no momento.\n\nDatalhe do erro: {ex}", "Recurso indisponível", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuBlocoDeNotas_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Desculpe, mas este recurso não pode ser acessado no momento.\n\nDatalhe do erro: {ex}", "Recurso indisponível", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MnuSobreEsteSoftware_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }
        #endregion

        #region Eventos dos TextBoxes
        private void TxtEnderecoIPDec_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoCalcular();
            if (TxtEnderecoIPDec.Text == "0.0.0.0" || string.IsNullOrWhiteSpace(TxtEnderecoIPDec.Text) || string.IsNullOrEmpty(TxtEnderecoIPDec.Text))
            {
                TxtCIDREndIP.ReadOnly = true;
            }
            else
            {
                TxtCIDREndIP.ReadOnly = false;
            }
        }

        private void TxtEnderecoIPBin_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotaoCalcular();
        }

        private void TxtCIDREndIP_TextChanged(object sender, EventArgs e)
        {
            Mascara mascara = new Mascara();

            if (TxtCIDREndIP.TextLength <= 0)
            {
                RtxtMensagens.Text = "O campo do CIDR não pode ficar vazio!";
                TxtCIDREndIP.Text = "0";
            }

            RbConvMascBinDec.Checked = true;
            TxtCIDRMasc.Text = TxtCIDREndIP.Text;
            int qtd1s = int.Parse(TxtCIDREndIP.Text);
            TxtMascaraBin.Text = mascara.InserirDigitosBin(qtd1s);
        }
        #endregion

        private void HabilitarBotaoCalcular()
        {
            if ((TxtEnderecoIPDec.Text == "0.0.0.0") || (string.IsNullOrWhiteSpace(TxtEnderecoIPDec.Text)))
            {
                BtnCalcular.Enabled = false;
            }
            else
            {
                BtnCalcular.Enabled = true;
            }
        }

        #region Eventos dos botões
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            EnderecoIP enderecoIPV4 = new EnderecoIP(this);

            if (TipoDeConversaoIP == false)
            {
                enderecoIPV4.ConverterIPDecimalParaBinario(1);
            }
            else
            {
                enderecoIPV4.ConverterIPBinarioParaDecimal(1);
            }

            Mascara mascara = new Mascara(this);

            if (TipoDeConversaoMascara == false)
            {
                mascara.ConverterMascaraDecimalParaBinario(1);
            }
            else
            {
                mascara.ConverterMascaraBinarioParaDecimal();
            }
        }

        private void BtnConverter_Click(object sender, EventArgs e)
        {
            EnderecoIP enderecoIPV4 = new EnderecoIP(this);

            if (TipoDeConversaoIP == false)
            {
                enderecoIPV4.ConverterIPDecimalParaBinario(2);
            }
            else
            {
                enderecoIPV4.ConverterIPBinarioParaDecimal(2);
            }

            Mascara mascara = new Mascara(this);

            if (TipoDeConversaoMascara == false)
            {
                mascara.ConverterMascaraDecimalParaBinario(2);
            }
            else
            {
                mascara.ConverterMascaraBinarioParaDecimal();
            }
        }

        private void BtnResetarCampos_Click(object sender, EventArgs e)
        {
            EnderecoIP enderecoIPV4 = new EnderecoIP(this);
            enderecoIPV4.ResetarCamposIP();

            Mascara mascara = new Mascara(this);
            mascara.ResetarCamposMascara();
        }

        private void BtnGerarLista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade será implementada em breve.", "Recurso em desenvolvimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void SelTipoConversaoMascara()
        {
            if (RbConvMascDecBin.Checked == true)
            {
                TxtMascaraDec.ReadOnly = false;
                TxtMascaraBin.ReadOnly = true;
                tipoDeConversaoMascara = false;
            }
            else
            {
                TxtMascaraDec.ReadOnly = true;
                TxtMascaraBin.ReadOnly = false;
                tipoDeConversaoMascara = true;
            }
        }

        private void SelTipoConversaoIP()
        {

            if (RbConvIPDecBin.Checked == true)
            {
                TxtEnderecoIPDec.ReadOnly = false;
                TxtEnderecoIPBin.ReadOnly = true;
                tipoDeConversaoIP = false;
            }
            else
            {
                TxtEnderecoIPDec.ReadOnly = true;
                TxtEnderecoIPBin.ReadOnly = false;
                tipoDeConversaoIP = true;
            }
        }

        #region Eventos dos RadioButtons de tipo de conversão
        private void RbConvIPDecBin_CheckedChanged(object sender, EventArgs e)
        {
            SelTipoConversaoIP();
        }

        private void RbConvIPBinDec_CheckedChanged(object sender, EventArgs e)
        {
            SelTipoConversaoIP();
        }

        private void RbConvMascDecBin_CheckedChanged(object sender, EventArgs e)
        {
            SelTipoConversaoMascara();
        }

        private void RbConvMascBinDec_CheckedChanged(object sender, EventArgs e)
        {
            SelTipoConversaoMascara();
        }

        #endregion
    }
}