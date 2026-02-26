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
            this.chkempresas = new System.Windows.Forms.CheckedListBox();
            this.tpInsc = new System.Windows.Forms.TabPage();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblInscPIsnc = new System.Windows.Forms.Label();
            this.lstInscPInsc = new System.Windows.Forms.ListBox();
            this.imgInsc = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.ttDate = new System.Windows.Forms.ToolTip(this.components);
            this.ttProg = new System.Windows.Forms.ToolTip(this.components);
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
            this.tbcInsc.Margin = new System.Windows.Forms.Padding(2);
            this.tbcInsc.Name = "tbcInsc";
            this.tbcInsc.SelectedIndex = 0;
            this.tbcInsc.Size = new System.Drawing.Size(599, 332);
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
            this.tpid.Location = new System.Drawing.Point(4, 23);
            this.tpid.Margin = new System.Windows.Forms.Padding(2);
            this.tpid.Name = "tpid";
            this.tpid.Padding = new System.Windows.Forms.Padding(2);
            this.tpid.Size = new System.Drawing.Size(591, 305);
            this.tpid.TabIndex = 0;
            this.tpid.Text = "Identificação";
            this.tpid.UseVisualStyleBackColor = true;
            // 
            // lblInsc
            // 
            this.lblInsc.AutoSize = true;
            this.lblInsc.Location = new System.Drawing.Point(5, 269);
            this.lblInsc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsc.Name = "lblInsc";
            this.lblInsc.Size = new System.Drawing.Size(64, 13);
            this.lblInsc.TabIndex = 8;
            this.lblInsc.Text = "0 Inscrições";
            // 
            // prbInsc
            // 
            this.prbInsc.Location = new System.Drawing.Point(5, 284);
            this.prbInsc.Margin = new System.Windows.Forms.Padding(2);
            this.prbInsc.Name = "prbInsc";
            this.prbInsc.Size = new System.Drawing.Size(582, 19);
            this.prbInsc.TabIndex = 7;
            this.ttProg.SetToolTip(this.prbInsc, "Máximo 6 inscrições (3 por área)");
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(244, 196);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd-MM-yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(236, 158);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(151, 20);
            this.dtpData.TabIndex = 5;
            this.ttDate.SetToolTip(this.dtpData, "Antecedência mínima de");
            this.dtpData.Value = new System.DateTime(2026, 2, 9, 0, 0, 0, 0);
            // 
            // lblDatadI
            // 
            this.lblDatadI.AutoSize = true;
            this.lblDatadI.Location = new System.Drawing.Point(233, 133);
            this.lblDatadI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatadI.Name = "lblDatadI";
            this.lblDatadI.Size = new System.Drawing.Size(73, 13);
            this.lblDatadI.TabIndex = 2;
            this.lblDatadI.Text = "Data de Ínicio";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(146, 74);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.MaxLength = 6;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(183, 20);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFem);
            this.grpGenero.Controls.Add(this.rdbMasc);
            this.grpGenero.Location = new System.Drawing.Point(16, 133);
            this.grpGenero.Margin = new System.Windows.Forms.Padding(2);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Padding = new System.Windows.Forms.Padding(2);
            this.grpGenero.Size = new System.Drawing.Size(109, 108);
            this.grpGenero.TabIndex = 4;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(12, 65);
            this.rdbFem.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(67, 17);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Checked = true;
            this.rdbMasc.Location = new System.Drawing.Point(12, 25);
            this.rdbMasc.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 74);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(76, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(144, 58);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Número";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 58);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tpEmpresa
            // 
            this.tpEmpresa.Controls.Add(this.txtNovaempresa);
            this.tpEmpresa.Controls.Add(this.btnInscreverPEmpresa);
            this.tpEmpresa.Controls.Add(this.btnNempresa);
            this.tpEmpresa.Controls.Add(this.grpArea);
            this.tpEmpresa.Controls.Add(this.chkempresas);
            this.tpEmpresa.ImageIndex = 1;
            this.tpEmpresa.Location = new System.Drawing.Point(4, 23);
            this.tpEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.tpEmpresa.Name = "tpEmpresa";
            this.tpEmpresa.Padding = new System.Windows.Forms.Padding(2);
            this.tpEmpresa.Size = new System.Drawing.Size(591, 305);
            this.tpEmpresa.TabIndex = 1;
            this.tpEmpresa.Text = "Empresa";
            this.tpEmpresa.UseVisualStyleBackColor = true;
            // 
            // txtNovaempresa
            // 
            this.txtNovaempresa.Location = new System.Drawing.Point(439, 197);
            this.txtNovaempresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovaempresa.Name = "txtNovaempresa";
            this.txtNovaempresa.Size = new System.Drawing.Size(76, 20);
            this.txtNovaempresa.TabIndex = 13;
            this.txtNovaempresa.Visible = false;
            // 
            // btnInscreverPEmpresa
            // 
            this.btnInscreverPEmpresa.Location = new System.Drawing.Point(424, 15);
            this.btnInscreverPEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscreverPEmpresa.Name = "btnInscreverPEmpresa";
            this.btnInscreverPEmpresa.Size = new System.Drawing.Size(90, 19);
            this.btnInscreverPEmpresa.TabIndex = 12;
            this.btnInscreverPEmpresa.Text = "Inscrever";
            this.btnInscreverPEmpresa.UseVisualStyleBackColor = true;
            this.btnInscreverPEmpresa.Click += new System.EventHandler(this.btnInscreverPEmpresa_Click);
            // 
            // btnNempresa
            // 
            this.btnNempresa.Location = new System.Drawing.Point(260, 197);
            this.btnNempresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnNempresa.Name = "btnNempresa";
            this.btnNempresa.Size = new System.Drawing.Size(135, 19);
            this.btnNempresa.TabIndex = 11;
            this.btnNempresa.Text = "Nova Empresa";
            this.btnNempresa.UseVisualStyleBackColor = true;
            this.btnNempresa.Click += new System.EventHandler(this.btnNempresa_Click);
            // 
            // grpArea
            // 
            this.grpArea.Controls.Add(this.chkRedes);
            this.grpArea.Controls.Add(this.chkprog);
            this.grpArea.Location = new System.Drawing.Point(244, 5);
            this.grpArea.Margin = new System.Windows.Forms.Padding(2);
            this.grpArea.Name = "grpArea";
            this.grpArea.Padding = new System.Windows.Forms.Padding(2);
            this.grpArea.Size = new System.Drawing.Size(150, 81);
            this.grpArea.TabIndex = 10;
            this.grpArea.TabStop = false;
            this.grpArea.Text = "Área";
            // 
            // chkRedes
            // 
            this.chkRedes.AutoSize = true;
            this.chkRedes.Location = new System.Drawing.Point(4, 52);
            this.chkRedes.Margin = new System.Windows.Forms.Padding(2);
            this.chkRedes.Name = "chkRedes";
            this.chkRedes.Size = new System.Drawing.Size(57, 17);
            this.chkRedes.TabIndex = 9;
            this.chkRedes.Text = "Redes";
            this.chkRedes.UseVisualStyleBackColor = true;
            // 
            // chkprog
            // 
            this.chkprog.AutoSize = true;
            this.chkprog.Location = new System.Drawing.Point(4, 31);
            this.chkprog.Margin = new System.Windows.Forms.Padding(2);
            this.chkprog.Name = "chkprog";
            this.chkprog.Size = new System.Drawing.Size(89, 17);
            this.chkprog.TabIndex = 8;
            this.chkprog.Text = "Programação";
            this.chkprog.UseVisualStyleBackColor = true;
            // 
            // chkempresas
            // 
            this.chkempresas.FormattingEnabled = true;
            this.chkempresas.Items.AddRange(new object[] {
            "CDP-SI",
            "CGD",
            "CloserIT",
            "MainHub",
            "Quidgest",
            "SPM",
            "WidePartner"});
            this.chkempresas.Location = new System.Drawing.Point(4, 5);
            this.chkempresas.Margin = new System.Windows.Forms.Padding(2);
            this.chkempresas.Name = "chkempresas";
            this.chkempresas.Size = new System.Drawing.Size(160, 199);
            this.chkempresas.Sorted = true;
            this.chkempresas.TabIndex = 0;
            // 
            // tpInsc
            // 
            this.tpInsc.Controls.Add(this.btneliminar);
            this.tpInsc.Controls.Add(this.lblInscPIsnc);
            this.tpInsc.Controls.Add(this.lstInscPInsc);
            this.tpInsc.ImageIndex = 0;
            this.tpInsc.Location = new System.Drawing.Point(4, 23);
            this.tpInsc.Margin = new System.Windows.Forms.Padding(2);
            this.tpInsc.Name = "tpInsc";
            this.tpInsc.Padding = new System.Windows.Forms.Padding(2);
            this.tpInsc.Size = new System.Drawing.Size(591, 305);
            this.tpInsc.TabIndex = 2;
            this.tpInsc.Text = "Inscrições";
            this.tpInsc.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(490, 264);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblInscPIsnc
            // 
            this.lblInscPIsnc.AutoSize = true;
            this.lblInscPIsnc.Location = new System.Drawing.Point(5, 15);
            this.lblInscPIsnc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscPIsnc.Name = "lblInscPIsnc";
            this.lblInscPIsnc.Size = new System.Drawing.Size(64, 13);
            this.lblInscPIsnc.TabIndex = 1;
            this.lblInscPIsnc.Text = "0 Inscrições";
            // 
            // lstInscPInsc
            // 
            this.lstInscPInsc.FormattingEnabled = true;
            this.lstInscPInsc.Location = new System.Drawing.Point(5, 30);
            this.lstInscPInsc.Margin = new System.Windows.Forms.Padding(2);
            this.lstInscPInsc.Name = "lstInscPInsc";
            this.lstInscPInsc.Size = new System.Drawing.Size(198, 212);
            this.lstInscPInsc.TabIndex = 0;
            // 
            // imgInsc
            // 
            this.imgInsc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgInsc.ImageStream")));
            this.imgInsc.TransparentColor = System.Drawing.Color.Transparent;
            this.imgInsc.Images.SetKeyName(0, "Windows-01_27087.ico");
            this.imgInsc.Images.SetKeyName(1, "office_building_company_icon_231040.ico");
            this.imgInsc.Images.SetKeyName(2, "3925423-business-card-id-id-icon_111566.ico");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresaimg.ico");
            this.imageList1.Images.SetKeyName(1, "idimg.ico");
            this.imageList1.Images.SetKeyName(2, "inscimg.ico");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(535, 336);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbcInsc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inscrições";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckedListBox chkempresas;
        private System.Windows.Forms.TextBox txtNovaempresa;
        private System.Windows.Forms.Button btnInscreverPEmpresa;
        private System.Windows.Forms.Button btnNempresa;
        private System.Windows.Forms.Label lblInscPIsnc;
        private System.Windows.Forms.ListBox lstInscPInsc;
        private System.Windows.Forms.ImageList imgInsc;
        private System.Windows.Forms.Button btneliminar;
    }
}

