using System.Diagnostics;
using System.Windows.Forms;
using CalcSubnet.Classes;

namespace CalcSubnet
{
    public partial class FrmPrincipal : Form
    {
        private static bool tipoDeConversaoIP = false; // Decimal para Binário (padrão)
        private static bool tipoDeConversaoMascara = false; // Decimal para Binário (padrão)

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
            get => TxtCIDREndIPDec.Text;
            set => TxtCIDREndIPDec.Text = value;
        }

        public string TxtCIDRMascaraDecimal
        {
            get => TxtCIDRMascDec.Text;
            set => TxtCIDRMascDec.Text = value;
        }
        #endregion

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SelTipoConversaoIP();
            SelTipoConversaoMascara();
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
            Process.Start("Calc.exe");
        }
        #endregion

        #region Eventos dos botões
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            EnderecoIP enderecoIPV4 = new EnderecoIP(this);
            enderecoIPV4.ConverterIP();

            Mascara mascara = new Mascara(this);
            mascara.ConverterMascara();

            //mascara.DeterminarQtdSubredes();
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