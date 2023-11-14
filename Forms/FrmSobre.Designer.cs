namespace CalcSubnet.Forms
{
    partial class FrmSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobre));
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnIrAoGitHub = new Button();
            panel2 = new Panel();
            BtnFechar = new Button();
            label3 = new Label();
            panel3 = new Panel();
            PbIcone = new PictureBox();
            panel4 = new Panel();
            TxtVersao = new TextBox();
            label6 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbIcone).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(12, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 227);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(226, 81);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 4;
            label4.Text = "Versão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(203, 39);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "William Silva";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(192, 15);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 2;
            label1.Text = "Desenvolvido por";
            // 
            // BtnIrAoGitHub
            // 
            BtnIrAoGitHub.BackColor = SystemColors.ActiveCaptionText;
            BtnIrAoGitHub.BackgroundImage = (Image)resources.GetObject("BtnIrAoGitHub.BackgroundImage");
            BtnIrAoGitHub.BackgroundImageLayout = ImageLayout.Zoom;
            BtnIrAoGitHub.Location = new Point(211, 173);
            BtnIrAoGitHub.Name = "BtnIrAoGitHub";
            BtnIrAoGitHub.Size = new Size(79, 38);
            BtnIrAoGitHub.TabIndex = 1;
            BtnIrAoGitHub.UseVisualStyleBackColor = false;
            BtnIrAoGitHub.Click += BtnIrAoGitHub_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnFechar);
            panel2.Location = new Point(12, 308);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 37);
            panel2.TabIndex = 1;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(3, 3);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(494, 31);
            BtnFechar.TabIndex = 0;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Fira Code Retina", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(196, 18);
            label3.Name = "label3";
            label3.Size = new Size(173, 29);
            label3.TabIndex = 3;
            label3.Text = "CalcSubnet";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(PbIcone);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 63);
            panel3.TabIndex = 4;
            // 
            // PbIcone
            // 
            PbIcone.BackgroundImage = (Image)resources.GetObject("PbIcone.BackgroundImage");
            PbIcone.BackgroundImageLayout = ImageLayout.Zoom;
            PbIcone.Location = new Point(131, 0);
            PbIcone.Name = "PbIcone";
            PbIcone.Size = new Size(59, 63);
            PbIcone.TabIndex = 4;
            PbIcone.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(TxtVersao);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(BtnIrAoGitHub);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 227);
            panel4.TabIndex = 6;
            // 
            // TxtVersao
            // 
            TxtVersao.BackColor = SystemColors.ButtonHighlight;
            TxtVersao.BorderStyle = BorderStyle.None;
            TxtVersao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtVersao.Location = new Point(131, 101);
            TxtVersao.MaxLength = 20;
            TxtVersao.Name = "TxtVersao";
            TxtVersao.ReadOnly = true;
            TxtVersao.Size = new Size(248, 18);
            TxtVersao.TabIndex = 7;
            TxtVersao.TabStop = false;
            TxtVersao.TextAlign = HorizontalAlignment.Center;
            TxtVersao.WordWrap = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(177, 151);
            label6.Name = "label6";
            label6.Size = new Size(147, 17);
            label6.TabIndex = 6;
            label6.Text = "Repositório no GitHub";
            // 
            // FrmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 351);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmSobre";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            TopMost = true;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbIcone).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnFechar;
        private Button BtnIrAoGitHub;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private PictureBox PbIcone;
        private Label label4;
        private Panel panel4;
        private Label label6;
        private TextBox TxtVersao;
    }
}