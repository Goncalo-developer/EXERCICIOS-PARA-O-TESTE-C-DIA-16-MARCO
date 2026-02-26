namespace Inter240083
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcInsc = new System.Windows.Forms.TabControl();
            this.tpid = new System.Windows.Forms.TabPage();
            this.lblInsc = new System.Windows.Forms.Label();
            this.prbInsc = new System.Windows.Forms.ProgressBar();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDatadI = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tpEmpresa = new System.Windows.Forms.TabPage();
            this.txtNovaempresa = new System.Windows.Forms.TextBox();
            this.btnInscreverPEmpresa = new System.Windows.Forms.Button();
            this.btnNempresa = new System.Windows.Forms.Button();
            this.grpArea = new System.Windows.Forms.GroupBox();
            this.chkRedes = new System.Windows.Forms.CheckBox();
            this.chkprog = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tpInsc = new System.Windows.Forms.TabPage();
            this.lblInscPIsnc = new System.Windows.Forms.Label();
            this.lstInscPInsc = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.ttDate = new System.Windows.Forms.ToolTip(this.components);
            this.ttProg = new System.Windows.Forms.ToolTip(this.components);
            this.imgInsc = new System.Windows.Forms.ImageList(this.components);
            this.tbcInsc.SuspendLayout();
            this.tpid.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.tpEmpresa.SuspendLayout();
            this.grpArea.SuspendLayout();
            this.tpInsc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcInsc
            // 
            this.tbcInsc.Controls.Add(this.tpid);
            this.tbcInsc.Controls.Add(this.tpEmpresa);
            this.tbcInsc.Controls.Add(this.tpInsc);
            this.tbcInsc.ImageList = this.imgInsc;
            this.tbcInsc.Location = new System.Drawing.Point(1, 0);
            this.tbcInsc.Name = "tbcInsc";
            this.tbcInsc.SelectedIndex = 0;
            this.tbcInsc.Size = new System.Drawing.Size(799, 408);
            this.tbcInsc.TabIndex = 0;
            // 
            // tpid
            // 
            this.tpid.Controls.Add(this.lblInsc);
            this.tpid.Controls.Add(this.prbInsc);
            this.tpid.Controls.Add(this.btnLimpar);
            this.tpid.Controls.Add(this.dtpData);
            this.tpid.Controls.Add(this.lblDatadI);
            this.tpid.Controls.Add(this.txtNum);
            this.tpid.Controls.Add(this.grpGenero);
            this.tpid.Controls.Add(this.txtNome);
            this.tpid.Controls.Add(this.lblNum);
            this.tpid.Controls.Add(this.lblNome);
            this.tpid.ImageIndex = 2;
            this.tpid.Location = new System.Drawing.Point(4, 25);
            this.tpid.Name = "tpid";
            this.tpid.Padding = new System.Windows.Forms.Padding(3);
            this.tpid.Size = new System.Drawing.Size(791, 379);
            this.tpid.TabIndex = 0;
            this.tpid.Text = "Identificação";
            this.tpid.UseVisualStyleBackColor = true;
            // 
            // lblInsc
            // 
            this.lblInsc.AutoSize = true;
            this.lblInsc.Location = new System.Drawing.Point(7, 331);
            this.lblInsc.Name = "lblInsc";
            this.lblInsc.Size = new System.Drawing.Size(78, 16);
            this.lblInsc.TabIndex = 8;
            this.lblInsc.Text = "0 Inscrições";
            // 
            // prbInsc
            // 
            this.prbInsc.Location = new System.Drawing.Point(7, 350);
            this.prbInsc.Name = "prbInsc";
            this.prbInsc.Size = new System.Drawing.Size(776, 23);
            this.prbInsc.TabIndex = 7;
            this.ttProg.SetToolTip(this.prbInsc, "Máximo 6 inscrições (3 por área)");
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(325, 241);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd-MM-yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(314, 195);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 5;
            this.ttDate.SetToolTip(this.dtpData, "Antecedência mínima de");
            this.dtpData.Value = new System.DateTime(2026, 2, 9, 0, 0, 0, 0);
            // 
            // lblDatadI
            // 
            this.lblDatadI.AutoSize = true;
            this.lblDatadI.Location = new System.Drawing.Point(311, 164);
            this.lblDatadI.Name = "lblDatadI";
            this.lblDatadI.Size = new System.Drawing.Size(89, 16);
            this.lblDatadI.TabIndex = 2;
            this.lblDatadI.Text = "Data de Ínicio";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(195, 91);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(243, 22);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFem);
            this.grpGenero.Controls.Add(this.rdbMasc);
            this.grpGenero.Location = new System.Drawing.Point(22, 164);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(145, 133);
            this.grpGenero.TabIndex = 4;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(16, 80);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(83, 20);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Checked = true;
            this.rdbMasc.Location = new System.Drawing.Point(16, 31);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(89, 20);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 91);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(192, 72);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 16);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Número";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 72);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tpEmpresa
            // 
            this.tpEmpresa.Controls.Add(this.txtNovaempresa);
            this.tpEmpresa.Controls.Add(this.btnInscreverPEmpresa);
            this.tpEmpresa.Controls.Add(this.btnNempresa);
            this.tpEmpresa.Controls.Add(this.grpArea);
            this.tpEmpresa.Controls.Add(this.checkedListBox1);
            this.tpEmpresa.ImageIndex = 1;
            this.tpEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tpEmpresa.Name = "tpEmpresa";
            this.tpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmpresa.Size = new System.Drawing.Size(791, 379);
            this.tpEmpresa.TabIndex = 1;
            this.tpEmpresa.Text = "Empresa";
            this.tpEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtNovaempresa
            // 
            this.txtNovaempresa.Location = new System.Drawing.Point(585, 243);
            this.txtNovaempresa.Name = "txtNovaempresa";
            this.txtNovaempresa.Size = new System.Drawing.Size(100, 22);
            this.txtNovaempresa.TabIndex = 13;
            this.txtNovaempresa.Visible = false;
            // 
            // btnInscreverPEmpresa
            // 
            this.btnInscreverPEmpresa.Location = new System.Drawing.Point(565, 19);
            this.btnInscreverPEmpresa.Name = "btnInscreverPEmpresa";
            this.btnInscreverPEmpresa.Size = new System.Drawing.Size(120, 23);
            this.btnInscreverPEmpresa.TabIndex = 12;
            this.btnInscreverPEmpresa.Text = "Inscrever";
            this.btnInscreverPEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnNempresa
            // 
            this.btnNempresa.Location = new System.Drawing.Point(346, 242);
            this.btnNempresa.Name = "btnNempresa";
            this.btnNempresa.Size = new System.Drawing.Size(180, 23);
            this.btnNempresa.TabIndex = 11;
            this.btnNempresa.Text = "Nova Empresa";
            this.btnNempresa.UseVisualStyleBackColor = true;
            // 
            // grpArea
            // 
            this.grpArea.Controls.Add(this.chkRedes);
            this.grpArea.Controls.Add(this.chkprog);
            this.grpArea.Location = new System.Drawing.Point(326, 6);
            this.grpArea.Name = "grpArea";
            this.grpArea.Size = new System.Drawing.Size(200, 100);
            this.grpArea.TabIndex = 10;
            this.grpArea.TabStop = false;
            this.grpArea.Text = "Área";
            // 
            // chkRedes
            // 
            this.chkRedes.AutoSize = true;
            this.chkRedes.Location = new System.Drawing.Point(6, 64);
            this.chkRedes.Name = "chkRedes";
            this.chkRedes.Size = new System.Drawing.Size(70, 20);
            this.chkRedes.TabIndex = 9;
            this.chkRedes.Text = "Redes";
            this.chkRedes.UseVisualStyleBackColor = true;
            // 
            // chkprog
            // 
            this.chkprog.AutoSize = true;
            this.chkprog.Location = new System.Drawing.Point(6, 38);
            this.chkprog.Name = "chkprog";
            this.chkprog.Size = new System.Drawing.Size(112, 20);
            this.chkprog.TabIndex = 8;
            this.chkprog.Text = "Programação";
            this.chkprog.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "CDP-SI",
            "CGD",
            "CloserIT",
            "MainHub",
            "Quidgest",
            "SPM",
            "WidePartner"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(212, 259);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 0;
            // 
            // tpInsc
            // 
            this.tpInsc.Controls.Add(this.lblInscPIsnc);
            this.tpInsc.Controls.Add(this.lstInscPInsc);
            this.tpInsc.ImageIndex = 0;
            this.tpInsc.Location = new System.Drawing.Point(4, 25);
            this.tpInsc.Name = "tpInsc";
            this.tpInsc.Padding = new System.Windows.Forms.Padding(3);
            this.tpInsc.Size = new System.Drawing.Size(791, 379);
            this.tpInsc.TabIndex = 2;
            this.tpInsc.Text = "Inscrições";
            this.tpInsc.UseVisualStyleBackColor = true;
            // 
            // lblInscPIsnc
            // 
            this.lblInscPIsnc.AutoSize = true;
            this.lblInscPIsnc.Location = new System.Drawing.Point(7, 18);
            this.lblInscPIsnc.Name = "lblInscPIsnc";
            this.lblInscPIsnc.Size = new System.Drawing.Size(78, 16);
            this.lblInscPIsnc.TabIndex = 1;
            this.lblInscPIsnc.Text = "0 Inscrições";
            // 
            // lstInscPInsc
            // 
            this.lstInscPInsc.FormattingEnabled = true;
            this.lstInscPInsc.ItemHeight = 16;
            this.lstInscPInsc.Items.AddRange(new object[] {
            "Programação",
            "Redes"});
            this.lstInscPInsc.Location = new System.Drawing.Point(7, 37);
            this.lstInscPInsc.Name = "lstInscPInsc";
            this.lstInscPInsc.Size = new System.Drawing.Size(263, 260);
            this.lstInscPInsc.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(713, 414);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // imgInsc
            // 
            this.imgInsc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgInsc.ImageStream")));
            this.imgInsc.TransparentColor = System.Drawing.Color.Transparent;
            this.imgInsc.Images.SetKeyName(0, "Windows-01_27087.ico");
            this.imgInsc.Images.SetKeyName(1, "office_building_company_icon_231040.ico");
            this.imgInsc.Images.SetKeyName(2, "3925423-business-card-id-id-icon_111566.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbcInsc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inscrições";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tbcInsc.ResumeLayout(false);
            this.tpid.ResumeLayout(false);
            this.tpid.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.tpEmpresa.ResumeLayout(false);
            this.tpEmpresa.PerformLayout();
            this.grpArea.ResumeLayout(false);
            this.grpArea.PerformLayout();
            this.tpInsc.ResumeLayout(false);
            this.tpInsc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcInsc;
        private System.Windows.Forms.TabPage tpid;
        private System.Windows.Forms.TabPage tpEmpresa;
        private System.Windows.Forms.TabPage tpInsc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDatadI;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInsc;
        private System.Windows.Forms.ProgressBar prbInsc;
        private System.Windows.Forms.ToolTip ttDate;
        private System.Windows.Forms.ToolTip ttProg;
        private System.Windows.Forms.CheckBox chkRedes;
        private System.Windows.Forms.CheckBox chkprog;
        private System.Windows.Forms.GroupBox grpArea;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtNovaempresa;
        private System.Windows.Forms.Button btnInscreverPEmpresa;
        private System.Windows.Forms.Button btnNempresa;
        private System.Windows.Forms.Label lblInscPIsnc;
        private System.Windows.Forms.ListBox lstInscPInsc;
        private System.Windows.Forms.ImageList imgInsc;
    }
}

