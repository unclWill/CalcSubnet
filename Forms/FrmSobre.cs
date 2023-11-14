using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace CalcSubnet.Forms
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
            TxtVersao.Text = Program.ExibirVersao();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIrAoGitHub_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ir ao repositório do projeto no GitHub?", "Acessar link externo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string linkRepo = "https://github.com/unclWill/CalcSubnet";
                Process browser = new Process();

                try
                {
                    browser.StartInfo.UseShellExecute = true;
                    browser.StartInfo.FileName = linkRepo;
                    browser.Start();
                }
                catch (Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (Exception other)
                {
                    MessageBox.Show(other.Message);
                }
            }
        }
    }
}
