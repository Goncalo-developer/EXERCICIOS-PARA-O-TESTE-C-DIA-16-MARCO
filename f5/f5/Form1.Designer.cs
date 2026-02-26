namespace f5
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cbbCursos = new System.Windows.Forms.ComboBox();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.btnInscrever = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.trvInscricoes = new System.Windows.Forms.TreeView();
            this.lblInsc = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(17, 21);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(44, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numero";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(229, 21);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(20, 45);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(76, 20);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // cbbCursos
            // 
            this.cbbCursos.FormattingEnabled = true;
            this.cbbCursos.Items.AddRange(new object[] {
            "TGPSI",
            "TEAC",
            "TER",
            "TG",
            "TOO",
            "TM"});
            this.cbbCursos.Location = new System.Drawing.Point(224, 45);
            this.cbbCursos.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCursos.Name = "cbbCursos";
            this.cbbCursos.Size = new System.Drawing.Size(92, 21);
            this.cbbCursos.TabIndex = 3;
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rdbFem);
            this.grbGenero.Controls.Add(this.rdbMasc);
            this.grbGenero.Location = new System.Drawing.Point(9, 91);
            this.grbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Padding = new System.Windows.Forms.Padding(2);
            this.grbGenero.Size = new System.Drawing.Size(125, 107);
            this.grbGenero.TabIndex = 4;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Sexo";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.ImageList = this.imageList1;
            this.rdbFem.Location = new System.Drawing.Point(3, 63);
            this.rdbFem.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(71, 17);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.Text = "Femenino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-Female-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-Male-50.png");
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Checked = true;
            this.rdbMasc.ImageList = this.imageList1;
            this.rdbMasc.Location = new System.Drawing.Point(2, 15);
            this.rdbMasc.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // btnInscrever
            // 
            this.btnInscrever.Enabled = false;
            this.btnInscrever.Location = new System.Drawing.Point(294, 103);
            this.btnInscrever.Margin = new System.Windows.Forms.Padding(2);
            this.btnInscrever.Name = "btnInscrever";
            this.btnInscrever.Size = new System.Drawing.Size(56, 19);
            this.btnInscrever.TabIndex = 5;
            this.btnInscrever.Text = "Increver";
            this.btnInscrever.UseVisualStyleBackColor = true;
            this.btnInscrever.Click += new System.EventHandler(this.btnInscrever_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(294, 180);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // trvInscricoes
            // 
            this.trvInscricoes.Location = new System.Drawing.Point(12, 221);
            this.trvInscricoes.Margin = new System.Windows.Forms.Padding(2);
            this.trvInscricoes.Name = "trvInscricoes";
            this.trvInscricoes.Size = new System.Drawing.Size(350, 135);
            this.trvInscricoes.TabIndex = 7;
            this.trvInscricoes.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvInscricoes_AfterCollapse);
            this.trvInscricoes.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvInscricoes_AfterExpand);
            this.trvInscricoes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvInscricoes_AfterSelect);
            // 
            // lblInsc
            // 
            this.lblInsc.AutoSize = true;
            this.lblInsc.Location = new System.Drawing.Point(9, 206);
            this.lblInsc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsc.Name = "lblInsc";
            this.lblInsc.Size = new System.Drawing.Size(55, 13);
            this.lblInsc.TabIndex = 8;
            this.lblInsc.Text = "Inscrições";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(513, 333);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
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
            this.Controls.Add(this.lblInsc);
            this.Controls.Add(this.trvInscricoes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInscrever);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.cbbCursos);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inscrições (tree view)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cbbCursos;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.Button btnInscrever;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TreeView trvInscricoes;
        private System.Windows.Forms.Label lblInsc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnOK;
    }
}

