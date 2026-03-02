namespace f6
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cbbCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.btnInsc = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.lstvInsc = new System.Windows.Forms.ListView();
            this.clmNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imglist1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.grpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 17);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(55, 16);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numero";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 36);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // cbbCurso
            // 
            this.cbbCurso.FormattingEnabled = true;
            this.cbbCurso.Items.AddRange(new object[] {
            "TGPSI",
            "TEAC",
            "TOO",
            "TER",
            "TOSP"});
            this.cbbCurso.Location = new System.Drawing.Point(272, 36);
            this.cbbCurso.Name = "cbbCurso";
            this.cbbCurso.Size = new System.Drawing.Size(75, 24);
            this.cbbCurso.TabIndex = 2;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(269, 17);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(42, 16);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFem);
            this.grpGenero.Controls.Add(this.rdbMasc);
            this.grpGenero.Location = new System.Drawing.Point(12, 91);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(200, 100);
            this.grpGenero.TabIndex = 4;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Checked = true;
            this.rdbMasc.Location = new System.Drawing.Point(3, 27);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(89, 20);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(3, 63);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(83, 20);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // btnInsc
            // 
            this.btnInsc.Enabled = false;
            this.btnInsc.ImageList = this.imglist1;
            this.btnInsc.Location = new System.Drawing.Point(301, 100);
            this.btnInsc.Name = "btnInsc";
            this.btnInsc.Size = new System.Drawing.Size(75, 23);
            this.btnInsc.TabIndex = 5;
            this.btnInsc.Text = "Inscrever";
            this.btnInsc.UseVisualStyleBackColor = true;
            this.btnInsc.Click += new System.EventHandler(this.btnInsc_Click);
            // 
            // btnElim
            // 
            this.btnElim.Enabled = false;
            this.btnElim.Location = new System.Drawing.Point(301, 168);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(75, 23);
            this.btnElim.TabIndex = 6;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            // 
            // lstvInsc
            // 
            this.lstvInsc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNum,
            this.clmGenero,
            this.clmCurso});
            this.lstvInsc.GridLines = true;
            this.lstvInsc.HideSelection = false;
            this.lstvInsc.Location = new System.Drawing.Point(35, 236);
            this.lstvInsc.Name = "lstvInsc";
            this.lstvInsc.Size = new System.Drawing.Size(349, 175);
            this.lstvInsc.SmallImageList = this.imglist1;
            this.lstvInsc.StateImageList = this.imglist1;
            this.lstvInsc.TabIndex = 2;
            this.lstvInsc.UseCompatibleStateImageBehavior = false;
            this.lstvInsc.View = System.Windows.Forms.View.Details;
            // 
            // clmNum
            // 
            this.clmNum.Text = "Número";
            this.clmNum.Width = 100;
            // 
            // clmGenero
            // 
            this.clmGenero.Text = "Género";
            this.clmGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmGenero.Width = 70;
            // 
            // clmCurso
            // 
            this.clmCurso.Text = "Curso";
            this.clmCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmCurso.Width = 80;
            // 
            // imglist1
            // 
            this.imglist1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist1.ImageStream")));
            this.imglist1.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist1.Images.SetKeyName(0, "female.png");
            this.imglist1.Images.SetKeyName(1, "male.png");
            this.imglist1.Images.SetKeyName(2, "CTRCAN.ICO");
            this.imglist1.Images.SetKeyName(3, "CTRFRAN.ICO");
            this.imglist1.Images.SetKeyName(4, "CTRMEX.ICO");
            this.imglist1.Images.SetKeyName(5, "CTRSKOR.ICO");
            this.imglist1.Images.SetKeyName(6, "CTRSPAIN.ICO");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(20, 417);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(379, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstvInsc);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnInsc);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cbbCurso);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNum);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inscrições (List View)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ComboBox cbbCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Button btnInsc;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.ListView lstvInsc;
        private System.Windows.Forms.ColumnHeader clmNum;
        private System.Windows.Forms.ColumnHeader clmGenero;
        private System.Windows.Forms.ColumnHeader clmCurso;
        private System.Windows.Forms.ImageList imglist1;
        private System.Windows.Forms.Button btnOK;
    }
}

