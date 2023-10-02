namespace CalcSubnet
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            groupBox1 = new GroupBox();
            groupBox8 = new GroupBox();
            label9 = new Label();
            panel4 = new Panel();
            TxtClasseIP = new TextBox();
            groupBox7 = new GroupBox();
            label6 = new Label();
            panel3 = new Panel();
            TxtQtdHostsPossiveis = new TextBox();
            groupBox4 = new GroupBox();
            label8 = new Label();
            panel1 = new Panel();
            TxtQtdSubredes = new TextBox();
            GpbEndRedeBroadcast = new GroupBox();
            TxtEnderecoIPDeBroadcast = new TextBox();
            label5 = new Label();
            TxtEnderecoIPDeRede = new TextBox();
            label1 = new Label();
            groupBox6 = new GroupBox();
            BtnGerarLista = new Button();
            BtnResetarCampos = new Button();
            BtnCalcular = new Button();
            groupBox2 = new GroupBox();
            RbConvIPBinDec = new RadioButton();
            RbConvIPDecBin = new RadioButton();
            groupBox5 = new GroupBox();
            label7 = new Label();
            panel2 = new Panel();
            TxtQtdHosts = new TextBox();
            GpbMascara = new GroupBox();
            groupBox10 = new GroupBox();
            TxtMascaraBin = new TextBox();
            groupBox11 = new GroupBox();
            TxtMascaraDec = new TextBox();
            label13 = new Label();
            TxtCIDRMascDec = new TextBox();
            label16 = new Label();
            label17 = new Label();
            GpbIPv4 = new GroupBox();
            GpbIPv4EndBin = new GroupBox();
            TxtEnderecoIPBin = new TextBox();
            GpbIPv4EndDec = new GroupBox();
            TxtEnderecoIPDec = new TextBox();
            label2 = new Label();
            TxtCIDREndIPDec = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            RbConvMascDecBin = new RadioButton();
            RbConvMascBinDec = new RadioButton();
            MnuPrincipal = new MenuStrip();
            MnuArquivo = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            MnuSair = new ToolStripMenuItem();
            MnuFerramentas = new ToolStripMenuItem();
            MnuCalculadora = new ToolStripMenuItem();
            MnuSobre = new ToolStripMenuItem();
            MnuSobreEsteSoftware = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox8.SuspendLayout();
            panel4.SuspendLayout();
            groupBox7.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            GpbEndRedeBroadcast.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            panel2.SuspendLayout();
            GpbMascara.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            GpbIPv4.SuspendLayout();
            GpbIPv4EndBin.SuspendLayout();
            GpbIPv4EndDec.SuspendLayout();
            groupBox3.SuspendLayout();
            MnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(GpbEndRedeBroadcast);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(GpbMascara);
            groupBox1.Controls.Add(GpbIPv4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(805, 617);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label9);
            groupBox8.Controls.Add(panel4);
            groupBox8.Location = new Point(26, 428);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(86, 91);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "Classe do IP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 38);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleGreen;
            panel4.Controls.Add(TxtClasseIP);
            panel4.Location = new Point(17, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 50);
            panel4.TabIndex = 2;
            // 
            // TxtClasseIP
            // 
            TxtClasseIP.BackColor = Color.PaleGreen;
            TxtClasseIP.BorderStyle = BorderStyle.None;
            TxtClasseIP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtClasseIP.Location = new Point(3, 12);
            TxtClasseIP.MaxLength = 3;
            TxtClasseIP.Name = "TxtClasseIP";
            TxtClasseIP.Size = new Size(45, 26);
            TxtClasseIP.TabIndex = 0;
            TxtClasseIP.Text = "C";
            TxtClasseIP.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(panel3);
            groupBox7.Location = new Point(563, 428);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(207, 91);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Quantidade de endereços possíveis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 73);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 1;
            label6.Text = "Hosts";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(TxtQtdHostsPossiveis);
            panel3.Location = new Point(25, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(164, 50);
            panel3.TabIndex = 2;
            // 
            // TxtQtdHostsPossiveis
            // 
            TxtQtdHostsPossiveis.BackColor = Color.LightSkyBlue;
            TxtQtdHostsPossiveis.BorderStyle = BorderStyle.None;
            TxtQtdHostsPossiveis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtQtdHostsPossiveis.Location = new Point(0, 12);
            TxtQtdHostsPossiveis.MaxLength = 3;
            TxtQtdHostsPossiveis.Name = "TxtQtdHostsPossiveis";
            TxtQtdHostsPossiveis.Size = new Size(164, 26);
            TxtQtdHostsPossiveis.TabIndex = 0;
            TxtQtdHostsPossiveis.Text = "16";
            TxtQtdHostsPossiveis.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(panel1);
            groupBox4.Location = new Point(132, 428);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(207, 91);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quantidade de sub-redes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 72);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 1;
            label8.Text = "Sub-redes possíveis";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(TxtQtdSubredes);
            panel1.Location = new Point(25, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 50);
            panel1.TabIndex = 2;
            // 
            // TxtQtdSubredes
            // 
            TxtQtdSubredes.BackColor = SystemColors.InactiveCaption;
            TxtQtdSubredes.BorderStyle = BorderStyle.None;
            TxtQtdSubredes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtQtdSubredes.Location = new Point(0, 12);
            TxtQtdSubredes.MaxLength = 3;
            TxtQtdSubredes.Name = "TxtQtdSubredes";
            TxtQtdSubredes.Size = new Size(164, 26);
            TxtQtdSubredes.TabIndex = 0;
            TxtQtdSubredes.Text = "16";
            TxtQtdSubredes.TextAlign = HorizontalAlignment.Center;
            // 
            // GpbEndRedeBroadcast
            // 
            GpbEndRedeBroadcast.Controls.Add(TxtEnderecoIPDeBroadcast);
            GpbEndRedeBroadcast.Controls.Add(label5);
            GpbEndRedeBroadcast.Controls.Add(TxtEnderecoIPDeRede);
            GpbEndRedeBroadcast.Controls.Add(label1);
            GpbEndRedeBroadcast.Location = new Point(247, 528);
            GpbEndRedeBroadcast.Name = "GpbEndRedeBroadcast";
            GpbEndRedeBroadcast.Size = new Size(310, 83);
            GpbEndRedeBroadcast.TabIndex = 6;
            GpbEndRedeBroadcast.TabStop = false;
            GpbEndRedeBroadcast.Text = "Endereço inicial e endereço final";
            // 
            // TxtEnderecoIPDeBroadcast
            // 
            TxtEnderecoIPDeBroadcast.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtEnderecoIPDeBroadcast.Location = new Point(161, 42);
            TxtEnderecoIPDeBroadcast.MaxLength = 15;
            TxtEnderecoIPDeBroadcast.Name = "TxtEnderecoIPDeBroadcast";
            TxtEnderecoIPDeBroadcast.Size = new Size(143, 25);
            TxtEnderecoIPDeBroadcast.TabIndex = 9;
            TxtEnderecoIPDeBroadcast.Text = "192.168.0.255";
            TxtEnderecoIPDeBroadcast.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 24);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 8;
            label5.Text = "Endereço de broadcast";
            // 
            // TxtEnderecoIPDeRede
            // 
            TxtEnderecoIPDeRede.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtEnderecoIPDeRede.Location = new Point(6, 42);
            TxtEnderecoIPDeRede.MaxLength = 15;
            TxtEnderecoIPDeRede.Name = "TxtEnderecoIPDeRede";
            TxtEnderecoIPDeRede.Size = new Size(143, 25);
            TxtEnderecoIPDeRede.TabIndex = 7;
            TxtEnderecoIPDeRede.Text = "192.168.0.0";
            TxtEnderecoIPDeRede.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 6;
            label1.Text = "Endereço de rede";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ButtonHighlight;
            groupBox6.Controls.Add(BtnGerarLista);
            groupBox6.Controls.Add(BtnResetarCampos);
            groupBox6.Controls.Add(BtnCalcular);
            groupBox6.Location = new Point(6, 316);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(793, 73);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ações";
            // 
            // BtnGerarLista
            // 
            BtnGerarLista.FlatAppearance.BorderColor = Color.Orange;
            BtnGerarLista.FlatAppearance.BorderSize = 2;
            BtnGerarLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGerarLista.Location = new Point(473, 24);
            BtnGerarLista.Name = "BtnGerarLista";
            BtnGerarLista.Size = new Size(197, 35);
            BtnGerarLista.TabIndex = 8;
            BtnGerarLista.Text = "Gerar lista com as faixas de IPs";
            BtnGerarLista.UseVisualStyleBackColor = true;
            BtnGerarLista.Click += BtnGerarLista_Click;
            // 
            // BtnResetarCampos
            // 
            BtnResetarCampos.FlatAppearance.BorderColor = Color.RoyalBlue;
            BtnResetarCampos.FlatAppearance.BorderSize = 2;
            BtnResetarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnResetarCampos.Location = new Point(344, 24);
            BtnResetarCampos.Name = "BtnResetarCampos";
            BtnResetarCampos.Size = new Size(123, 35);
            BtnResetarCampos.TabIndex = 9;
            BtnResetarCampos.Text = "Resetar campos";
            BtnResetarCampos.UseVisualStyleBackColor = true;
            BtnResetarCampos.Click += BtnResetarCampos_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.FlatAppearance.BorderColor = Color.YellowGreen;
            BtnCalcular.FlatAppearance.BorderSize = 2;
            BtnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.Location = new Point(100, 24);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(238, 35);
            BtnCalcular.TabIndex = 8;
            BtnCalcular.Text = "Converter";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RbConvIPBinDec);
            groupBox2.Controls.Add(RbConvIPDecBin);
            groupBox2.Location = new Point(6, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 70);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "IP | Tipo de conversão";
            // 
            // RbConvIPBinDec
            // 
            RbConvIPBinDec.AutoSize = true;
            RbConvIPBinDec.Location = new Point(93, 44);
            RbConvIPBinDec.Name = "RbConvIPBinDec";
            RbConvIPBinDec.Size = new Size(205, 19);
            RbConvIPBinDec.TabIndex = 10;
            RbConvIPBinDec.Text = "Converter de Binário para Decimal";
            RbConvIPBinDec.UseVisualStyleBackColor = true;
            RbConvIPBinDec.CheckedChanged += RbConvIPBinDec_CheckedChanged;
            // 
            // RbConvIPDecBin
            // 
            RbConvIPDecBin.AutoSize = true;
            RbConvIPDecBin.Checked = true;
            RbConvIPDecBin.Location = new Point(93, 21);
            RbConvIPDecBin.Name = "RbConvIPDecBin";
            RbConvIPDecBin.Size = new Size(205, 19);
            RbConvIPDecBin.TabIndex = 9;
            RbConvIPDecBin.TabStop = true;
            RbConvIPDecBin.Text = "Converter de Decimal para Binário";
            RbConvIPDecBin.UseVisualStyleBackColor = true;
            RbConvIPDecBin.CheckedChanged += RbConvIPDecBin_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(panel2);
            groupBox5.Location = new Point(350, 428);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(207, 91);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Quantidade de hosts";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 73);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 3;
            label7.Text = "Hosts por sub-rede";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(TxtQtdHosts);
            panel2.Location = new Point(25, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 50);
            panel2.TabIndex = 4;
            // 
            // TxtQtdHosts
            // 
            TxtQtdHosts.BackColor = SystemColors.AppWorkspace;
            TxtQtdHosts.BorderStyle = BorderStyle.None;
            TxtQtdHosts.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtQtdHosts.Location = new Point(3, 12);
            TxtQtdHosts.MaxLength = 3;
            TxtQtdHosts.Name = "TxtQtdHosts";
            TxtQtdHosts.Size = new Size(158, 26);
            TxtQtdHosts.TabIndex = 0;
            TxtQtdHosts.Text = "16";
            TxtQtdHosts.TextAlign = HorizontalAlignment.Center;
            // 
            // GpbMascara
            // 
            GpbMascara.Controls.Add(groupBox10);
            GpbMascara.Controls.Add(groupBox11);
            GpbMascara.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GpbMascara.Location = new Point(413, 96);
            GpbMascara.Name = "GpbMascara";
            GpbMascara.Size = new Size(386, 204);
            GpbMascara.TabIndex = 3;
            GpbMascara.TabStop = false;
            GpbMascara.Text = "Máscara";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(TxtMascaraBin);
            groupBox10.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox10.Location = new Point(6, 127);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(374, 71);
            groupBox10.TabIndex = 11;
            groupBox10.TabStop = false;
            groupBox10.Text = "Binário";
            // 
            // TxtMascaraBin
            // 
            TxtMascaraBin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMascaraBin.Location = new Point(16, 31);
            TxtMascaraBin.MaxLength = 35;
            TxtMascaraBin.Name = "TxtMascaraBin";
            TxtMascaraBin.Size = new Size(344, 27);
            TxtMascaraBin.TabIndex = 6;
            TxtMascaraBin.Text = "11111111.11111111.11111111.00000000";
            TxtMascaraBin.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(TxtMascaraDec);
            groupBox11.Controls.Add(label13);
            groupBox11.Controls.Add(TxtCIDRMascDec);
            groupBox11.Controls.Add(label16);
            groupBox11.Controls.Add(label17);
            groupBox11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox11.Location = new Point(6, 38);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(374, 83);
            groupBox11.TabIndex = 10;
            groupBox11.TabStop = false;
            groupBox11.Text = "Decimal";
            // 
            // TxtMascaraDec
            // 
            TxtMascaraDec.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMascaraDec.Location = new Point(16, 43);
            TxtMascaraDec.MaxLength = 15;
            TxtMascaraDec.Name = "TxtMascaraDec";
            TxtMascaraDec.Size = new Size(297, 27);
            TxtMascaraDec.TabIndex = 5;
            TxtMascaraDec.Text = "255.255.255.0";
            TxtMascaraDec.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(312, 46);
            label13.Name = "label13";
            label13.Size = new Size(16, 20);
            label13.TabIndex = 1;
            label13.Text = "/";
            // 
            // TxtCIDRMascDec
            // 
            TxtCIDRMascDec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCIDRMascDec.Location = new Point(326, 43);
            TxtCIDRMascDec.MaxLength = 2;
            TxtCIDRMascDec.Name = "TxtCIDRMascDec";
            TxtCIDRMascDec.ReadOnly = true;
            TxtCIDRMascDec.Size = new Size(37, 25);
            TxtCIDRMascDec.TabIndex = 6;
            TxtCIDRMascDec.Text = "24";
            TxtCIDRMascDec.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(327, 25);
            label16.Name = "label16";
            label16.Size = new Size(33, 15);
            label16.TabIndex = 3;
            label16.Text = "CIDR";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(119, 25);
            label17.Name = "label17";
            label17.Size = new Size(91, 15);
            label17.TabIndex = 4;
            label17.Text = "Máscara padrão";
            // 
            // GpbIPv4
            // 
            GpbIPv4.Controls.Add(GpbIPv4EndBin);
            GpbIPv4.Controls.Add(GpbIPv4EndDec);
            GpbIPv4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GpbIPv4.Location = new Point(6, 96);
            GpbIPv4.Name = "GpbIPv4";
            GpbIPv4.Size = new Size(391, 204);
            GpbIPv4.TabIndex = 2;
            GpbIPv4.TabStop = false;
            GpbIPv4.Text = "IPv4";
            // 
            // GpbIPv4EndBin
            // 
            GpbIPv4EndBin.Controls.Add(TxtEnderecoIPBin);
            GpbIPv4EndBin.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            GpbIPv4EndBin.Location = new Point(6, 127);
            GpbIPv4EndBin.Name = "GpbIPv4EndBin";
            GpbIPv4EndBin.Size = new Size(379, 71);
            GpbIPv4EndBin.TabIndex = 9;
            GpbIPv4EndBin.TabStop = false;
            GpbIPv4EndBin.Text = "Binário";
            // 
            // TxtEnderecoIPBin
            // 
            TxtEnderecoIPBin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtEnderecoIPBin.Location = new Point(14, 31);
            TxtEnderecoIPBin.MaxLength = 35;
            TxtEnderecoIPBin.Name = "TxtEnderecoIPBin";
            TxtEnderecoIPBin.Size = new Size(354, 27);
            TxtEnderecoIPBin.TabIndex = 6;
            TxtEnderecoIPBin.Text = "11000000.10101000.00000000.00000001";
            TxtEnderecoIPBin.TextAlign = HorizontalAlignment.Center;
            // 
            // GpbIPv4EndDec
            // 
            GpbIPv4EndDec.Controls.Add(TxtEnderecoIPDec);
            GpbIPv4EndDec.Controls.Add(label2);
            GpbIPv4EndDec.Controls.Add(TxtCIDREndIPDec);
            GpbIPv4EndDec.Controls.Add(label3);
            GpbIPv4EndDec.Controls.Add(label4);
            GpbIPv4EndDec.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            GpbIPv4EndDec.Location = new Point(6, 38);
            GpbIPv4EndDec.Name = "GpbIPv4EndDec";
            GpbIPv4EndDec.Size = new Size(379, 83);
            GpbIPv4EndDec.TabIndex = 8;
            GpbIPv4EndDec.TabStop = false;
            GpbIPv4EndDec.Text = "Decimal";
            // 
            // TxtEnderecoIPDec
            // 
            TxtEnderecoIPDec.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtEnderecoIPDec.Location = new Point(14, 43);
            TxtEnderecoIPDec.MaxLength = 15;
            TxtEnderecoIPDec.Name = "TxtEnderecoIPDec";
            TxtEnderecoIPDec.Size = new Size(298, 27);
            TxtEnderecoIPDec.TabIndex = 5;
            TxtEnderecoIPDec.Text = "192.168.0.1";
            TxtEnderecoIPDec.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(311, 46);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 1;
            label2.Text = "/";
            // 
            // TxtCIDREndIPDec
            // 
            TxtCIDREndIPDec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCIDREndIPDec.Location = new Point(326, 43);
            TxtCIDREndIPDec.MaxLength = 2;
            TxtCIDREndIPDec.Name = "TxtCIDREndIPDec";
            TxtCIDREndIPDec.ReadOnly = true;
            TxtCIDREndIPDec.Size = new Size(37, 25);
            TxtCIDREndIPDec.TabIndex = 6;
            TxtCIDREndIPDec.Text = "24";
            TxtCIDREndIPDec.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(327, 25);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "CIDR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 25);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 4;
            label4.Text = "Endereço";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RbConvMascDecBin);
            groupBox3.Controls.Add(RbConvMascBinDec);
            groupBox3.Location = new Point(413, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 65);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Máscara  | Tipo de conversão";
            // 
            // RbConvMascDecBin
            // 
            RbConvMascDecBin.AutoSize = true;
            RbConvMascDecBin.Checked = true;
            RbConvMascDecBin.Location = new Point(76, 19);
            RbConvMascDecBin.Name = "RbConvMascDecBin";
            RbConvMascDecBin.Size = new Size(205, 19);
            RbConvMascDecBin.TabIndex = 11;
            RbConvMascDecBin.TabStop = true;
            RbConvMascDecBin.Text = "Converter de Decimal para Binário";
            RbConvMascDecBin.UseVisualStyleBackColor = true;
            RbConvMascDecBin.CheckedChanged += RbConvMascDecBin_CheckedChanged;
            // 
            // RbConvMascBinDec
            // 
            RbConvMascBinDec.AutoSize = true;
            RbConvMascBinDec.Location = new Point(76, 39);
            RbConvMascBinDec.Name = "RbConvMascBinDec";
            RbConvMascBinDec.Size = new Size(205, 19);
            RbConvMascBinDec.TabIndex = 12;
            RbConvMascBinDec.TabStop = true;
            RbConvMascBinDec.Text = "Converter de Binário para Decimal";
            RbConvMascBinDec.UseVisualStyleBackColor = true;
            RbConvMascBinDec.CheckedChanged += RbConvMascBinDec_CheckedChanged;
            // 
            // MnuPrincipal
            // 
            MnuPrincipal.BackColor = Color.White;
            MnuPrincipal.Items.AddRange(new ToolStripItem[] { MnuArquivo, MnuFerramentas, MnuSobre });
            MnuPrincipal.Location = new Point(0, 0);
            MnuPrincipal.Name = "MnuPrincipal";
            MnuPrincipal.Size = new Size(829, 24);
            MnuPrincipal.TabIndex = 1;
            MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuArquivo
            // 
            MnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator1, MnuSair });
            MnuArquivo.Name = "MnuArquivo";
            MnuArquivo.Size = new Size(61, 20);
            MnuArquivo.Text = "&Arquivo";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&Novo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(146, 22);
            MnuSair.Text = "S&air";
            MnuSair.Click += MnuSair_Click;
            // 
            // MnuFerramentas
            // 
            MnuFerramentas.DropDownItems.AddRange(new ToolStripItem[] { MnuCalculadora });
            MnuFerramentas.Name = "MnuFerramentas";
            MnuFerramentas.Size = new Size(84, 20);
            MnuFerramentas.Text = "&Ferramentas";
            // 
            // MnuCalculadora
            // 
            MnuCalculadora.Name = "MnuCalculadora";
            MnuCalculadora.Size = new Size(180, 22);
            MnuCalculadora.Text = "&Calculadora";
            MnuCalculadora.Click += MnuCalculadora_Click;
            // 
            // MnuSobre
            // 
            MnuSobre.DropDownItems.AddRange(new ToolStripItem[] { MnuSobreEsteSoftware });
            MnuSobre.Name = "MnuSobre";
            MnuSobre.Size = new Size(49, 20);
            MnuSobre.Text = "&Sobre";
            // 
            // MnuSobreEsteSoftware
            // 
            MnuSobreEsteSoftware.Name = "MnuSobreEsteSoftware";
            MnuSobreEsteSoftware.Size = new Size(176, 22);
            MnuSobreEsteSoftware.Text = "&Sobre este software";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 654);
            Controls.Add(groupBox1);
            Controls.Add(MnuPrincipal);
            MainMenuStrip = MnuPrincipal;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalcSubnet v0.1.0 (beta)";
            Load += FrmPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            GpbEndRedeBroadcast.ResumeLayout(false);
            GpbEndRedeBroadcast.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            GpbMascara.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            GpbIPv4.ResumeLayout(false);
            GpbIPv4EndBin.ResumeLayout(false);
            GpbIPv4EndBin.PerformLayout();
            GpbIPv4EndDec.ResumeLayout(false);
            GpbIPv4EndDec.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            MnuPrincipal.ResumeLayout(false);
            MnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip MnuPrincipal;
        private ToolStripMenuItem MnuArquivo;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem MnuSair;
        private ToolStripMenuItem MnuFerramentas;
        private ToolStripMenuItem MnuSobre;
        private ToolStripMenuItem MnuSobreEsteSoftware;
        private GroupBox GpbMascara;
        private GroupBox GpbIPv4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TxtEnderecoIPDec;
        private TextBox TxtCIDREndIPDec;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox GpbEndRedeBroadcast;
        private TextBox TxtEnderecoIPDeBroadcast;
        private Label label5;
        private TextBox TxtEnderecoIPDeRede;
        private Label label1;
        private Label label8;
        private Panel panel1;
        private TextBox TxtQtdSubredes;
        private Label label7;
        private Panel panel2;
        private TextBox TxtQtdHosts;
        private Button BtnGerarLista;
        private GroupBox GpbIPv4EndBin;
        private GroupBox GpbIPv4EndDec;
        private Button BtnCalcular;
        private TextBox TxtEnderecoIPBin;
        private GroupBox groupBox10;
        private GroupBox groupBox11;
        private Label label13;
        private TextBox TxtCIDRMascDec;
        private Label label16;
        private Label label17;
        private GroupBox groupBox2;
        private RadioButton RbConvIPBinDec;
        private RadioButton RbConvIPDecBin;
        private TextBox TxtMascaraBin;
        private TextBox TxtMascaraDec;
        private RadioButton RbConvMascBinDec;
        private RadioButton RbConvMascDecBin;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private Button BtnResetarCampos;
        private ToolStripMenuItem MnuCalculadora;
        private GroupBox groupBox7;
        private Label label6;
        private Panel panel3;
        private TextBox TxtQtdHostsPossiveis;
        private GroupBox groupBox8;
        private Label label9;
        private Panel panel4;
        private TextBox TxtClasseIP;
    }
}