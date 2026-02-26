namespace ex2f2
{
    partial class Form1
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grbDisciplina = new System.Windows.Forms.GroupBox();
            this.rdbSO = new System.Windows.Forms.RadioButton();
            this.rdbRC = new System.Windows.Forms.RadioButton();
            this.rdbPSI = new System.Windows.Forms.RadioButton();
            this.rdbAC = new System.Windows.Forms.RadioButton();
            this.grbEpoca = new System.Windows.Forms.GroupBox();
            this.rdbOutra = new System.Windows.Forms.RadioButton();
            this.rdbVerao = new System.Windows.Forms.RadioButton();
            this.rdbPascoa = new System.Windows.Forms.RadioButton();
            this.rdbNatal = new System.Windows.Forms.RadioButton();
            this.ckb1vez = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblInscPsi = new System.Windows.Forms.Label();
            this.lblInscOutras = new System.Windows.Forms.Label();
            this.txtInscricoesScrollBar = new System.Windows.Forms.TextBox();
            this.grbDisciplina.SuspendLayout();
            this.grbEpoca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 17);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(227, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(21, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(136, 22);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(199, 34);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 22);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // grbDisciplina
            // 
            this.grbDisciplina.Controls.Add(this.rdbSO);
            this.grbDisciplina.Controls.Add(this.rdbRC);
            this.grbDisciplina.Controls.Add(this.rdbPSI);
            this.grbDisciplina.Controls.Add(this.rdbAC);
            this.grbDisciplina.Location = new System.Drawing.Point(21, 105);
            this.grbDisciplina.Name = "grbDisciplina";
            this.grbDisciplina.Size = new System.Drawing.Size(133, 165);
            this.grbDisciplina.TabIndex = 6;
            this.grbDisciplina.TabStop = false;
            this.grbDisciplina.Text = "Disciplina";
            // 
            // rdbSO
            // 
            this.rdbSO.AutoSize = true;
            this.rdbSO.Location = new System.Drawing.Point(7, 113);
            this.rdbSO.Name = "rdbSO";
            this.rdbSO.Size = new System.Drawing.Size(47, 20);
            this.rdbSO.TabIndex = 3;
            this.rdbSO.Text = "SO";
            this.rdbSO.UseVisualStyleBackColor = true;
            // 
            // rdbRC
            // 
            this.rdbRC.AutoSize = true;
            this.rdbRC.Location = new System.Drawing.Point(7, 86);
            this.rdbRC.Name = "rdbRC";
            this.rdbRC.Size = new System.Drawing.Size(47, 20);
            this.rdbRC.TabIndex = 2;
            this.rdbRC.Text = "RC";
            this.rdbRC.UseVisualStyleBackColor = true;
            // 
            // rdbPSI
            // 
            this.rdbPSI.AutoSize = true;
            this.rdbPSI.Checked = true;
            this.rdbPSI.Location = new System.Drawing.Point(7, 59);
            this.rdbPSI.Name = "rdbPSI";
            this.rdbPSI.Size = new System.Drawing.Size(49, 20);
            this.rdbPSI.TabIndex = 1;
            this.rdbPSI.TabStop = true;
            this.rdbPSI.Text = "PSI";
            this.rdbPSI.UseVisualStyleBackColor = true;
            // 
            // rdbAC
            // 
            this.rdbAC.AutoSize = true;
            this.rdbAC.Location = new System.Drawing.Point(7, 33);
            this.rdbAC.Name = "rdbAC";
            this.rdbAC.Size = new System.Drawing.Size(46, 20);
            this.rdbAC.TabIndex = 0;
            this.rdbAC.Text = "AC";
            this.rdbAC.UseVisualStyleBackColor = true;
            // 
            // grbEpoca
            // 
            this.grbEpoca.Controls.Add(this.rdbOutra);
            this.grbEpoca.Controls.Add(this.rdbVerao);
            this.grbEpoca.Controls.Add(this.rdbPascoa);
            this.grbEpoca.Controls.Add(this.rdbNatal);
            this.grbEpoca.Location = new System.Drawing.Point(209, 104);
            this.grbEpoca.Name = "grbEpoca";
            this.grbEpoca.Size = new System.Drawing.Size(170, 166);
            this.grbEpoca.TabIndex = 7;
            this.grbEpoca.TabStop = false;
            this.grbEpoca.Text = "Época";
            // 
            // rdbOutra
            // 
            this.rdbOutra.AutoSize = true;
            this.rdbOutra.Location = new System.Drawing.Point(21, 114);
            this.rdbOutra.Name = "rdbOutra";
            this.rdbOutra.Size = new System.Drawing.Size(60, 20);
            this.rdbOutra.TabIndex = 3;
            this.rdbOutra.TabStop = true;
            this.rdbOutra.Text = "Outra";
            this.rdbOutra.UseVisualStyleBackColor = true;
            // 
            // rdbVerao
            // 
            this.rdbVerao.AutoSize = true;
            this.rdbVerao.Location = new System.Drawing.Point(21, 87);
            this.rdbVerao.Name = "rdbVerao";
            this.rdbVerao.Size = new System.Drawing.Size(65, 20);
            this.rdbVerao.TabIndex = 2;
            this.rdbVerao.TabStop = true;
            this.rdbVerao.Text = "Verão";
            this.rdbVerao.UseVisualStyleBackColor = true;
            // 
            // rdbPascoa
            // 
            this.rdbPascoa.AutoSize = true;
            this.rdbPascoa.Location = new System.Drawing.Point(21, 60);
            this.rdbPascoa.Name = "rdbPascoa";
            this.rdbPascoa.Size = new System.Drawing.Size(75, 20);
            this.rdbPascoa.TabIndex = 1;
            this.rdbPascoa.TabStop = true;
            this.rdbPascoa.Text = "Páscoa";
            this.rdbPascoa.UseVisualStyleBackColor = true;
            // 
            // rdbNatal
            // 
            this.rdbNatal.AutoSize = true;
            this.rdbNatal.Location = new System.Drawing.Point(21, 34);
            this.rdbNatal.Name = "rdbNatal";
            this.rdbNatal.Size = new System.Drawing.Size(60, 20);
            this.rdbNatal.TabIndex = 0;
            this.rdbNatal.TabStop = true;
            this.rdbNatal.Text = "Natal";
            this.rdbNatal.UseVisualStyleBackColor = true;
            // 
            // ckb1vez
            // 
            this.ckb1vez.AutoSize = true;
            this.ckb1vez.Location = new System.Drawing.Point(412, 137);
            this.ckb1vez.Name = "ckb1vez";
            this.ckb1vez.Size = new System.Drawing.Size(67, 20);
            this.ckb1vez.TabIndex = 8;
            this.ckb1vez.Text = "1º Vez";
            this.ckb1vez.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Enabled = false;
            this.btnAdicionar.Location = new System.Drawing.Point(585, 247);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(299, 498);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblInscPsi
            // 
            this.lblInscPsi.AutoSize = true;
            this.lblInscPsi.Location = new System.Drawing.Point(28, 277);
            this.lblInscPsi.Name = "lblInscPsi";
            this.lblInscPsi.Size = new System.Drawing.Size(124, 16);
            this.lblInscPsi.TabIndex = 11;
            this.lblInscPsi.Text = "0 inscrições em PSI";
            this.lblInscPsi.TextChanged += new System.EventHandler(this.lblInscPsi_TextChanged);
            // 
            // lblInscOutras
            // 
            this.lblInscOutras.AutoSize = true;
            this.lblInscOutras.Location = new System.Drawing.Point(28, 297);
            this.lblInscOutras.Name = "lblInscOutras";
            this.lblInscOutras.Size = new System.Drawing.Size(190, 16);
            this.lblInscOutras.TabIndex = 12;
            this.lblInscOutras.Text = "0 inscrições noutas Disciplinas";
            // 
            // txtInscricoesScrollBar
            // 
            this.txtInscricoesScrollBar.Location = new System.Drawing.Point(28, 330);
            this.txtInscricoesScrollBar.Multiline = true;
            this.txtInscricoesScrollBar.Name = "txtInscricoesScrollBar";
            this.txtInscricoesScrollBar.Size = new System.Drawing.Size(632, 162);
            this.txtInscricoesScrollBar.TabIndex = 13;
            this.txtInscricoesScrollBar.TextChanged += new System.EventHandler(this.txtInscricoesScrollBar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 653);
            this.Controls.Add(this.txtInscricoesScrollBar);
            this.Controls.Add(this.lblInscOutras);
            this.Controls.Add(this.lblInscPsi);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ckb1vez);
            this.Controls.Add(this.grbEpoca);
            this.Controls.Add(this.grbDisciplina);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grbDisciplina.ResumeLayout(false);
            this.grbDisciplina.PerformLayout();
            this.grbEpoca.ResumeLayout(false);
            this.grbEpoca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grbDisciplina;
        private System.Windows.Forms.RadioButton rdbSO;
        private System.Windows.Forms.RadioButton rdbRC;
        private System.Windows.Forms.RadioButton rdbPSI;
        private System.Windows.Forms.RadioButton rdbAC;
        private System.Windows.Forms.GroupBox grbEpoca;
        private System.Windows.Forms.RadioButton rdbOutra;
        private System.Windows.Forms.RadioButton rdbVerao;
        private System.Windows.Forms.RadioButton rdbPascoa;
        private System.Windows.Forms.RadioButton rdbNatal;
        private System.Windows.Forms.CheckBox ckb1vez;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblInscPsi;
        private System.Windows.Forms.Label lblInscOutras;
        private System.Windows.Forms.TextBox txtInscricoesScrollBar;
    }
}

