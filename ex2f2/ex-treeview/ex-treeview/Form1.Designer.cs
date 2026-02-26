namespace ex_treeview
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
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.grb_sexo = new System.Windows.Forms.GroupBox();
            this.rdb_masc = new System.Windows.Forms.RadioButton();
            this.rdb_fem = new System.Windows.Forms.RadioButton();
            this.lbl_insc = new System.Windows.Forms.Label();
            this.cbb_curso = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.trv_insc = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_inscrever = new System.Windows.Forms.Button();
            this.grb_sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(12, 59);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(55, 16);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Número";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(300, 59);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(42, 16);
            this.lbl_curso.TabIndex = 1;
            this.lbl_curso.Text = "Curso";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(13, 79);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 22);
            this.txt_num.TabIndex = 2;
            this.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // grb_sexo
            // 
            this.grb_sexo.Controls.Add(this.rdb_fem);
            this.grb_sexo.Controls.Add(this.rdb_masc);
            this.grb_sexo.Location = new System.Drawing.Point(15, 161);
            this.grb_sexo.Name = "grb_sexo";
            this.grb_sexo.Size = new System.Drawing.Size(200, 100);
            this.grb_sexo.TabIndex = 4;
            this.grb_sexo.TabStop = false;
            this.grb_sexo.Text = "Sexo";
            // 
            // rdb_masc
            // 
            this.rdb_masc.AutoSize = true;
            this.rdb_masc.Checked = true;
            this.rdb_masc.ImageList = this.imageList1;
            this.rdb_masc.Location = new System.Drawing.Point(7, 22);
            this.rdb_masc.Name = "rdb_masc";
            this.rdb_masc.Size = new System.Drawing.Size(89, 20);
            this.rdb_masc.TabIndex = 0;
            this.rdb_masc.TabStop = true;
            this.rdb_masc.Text = "Masculino";
            this.rdb_masc.UseVisualStyleBackColor = true;
            // 
            // rdb_fem
            // 
            this.rdb_fem.AutoSize = true;
            this.rdb_fem.Location = new System.Drawing.Point(7, 58);
            this.rdb_fem.Name = "rdb_fem";
            this.rdb_fem.Size = new System.Drawing.Size(88, 20);
            this.rdb_fem.TabIndex = 1;
            this.rdb_fem.Text = "Femenino";
            this.rdb_fem.UseVisualStyleBackColor = true;
            // 
            // lbl_insc
            // 
            this.lbl_insc.AutoSize = true;
            this.lbl_insc.Location = new System.Drawing.Point(15, 303);
            this.lbl_insc.Name = "lbl_insc";
            this.lbl_insc.Size = new System.Drawing.Size(68, 16);
            this.lbl_insc.TabIndex = 5;
            this.lbl_insc.Text = "Inscrições";
            // 
            // cbb_curso
            // 
            this.cbb_curso.FormattingEnabled = true;
            this.cbb_curso.Items.AddRange(new object[] {
            "TGPSI",
            "TEAC",
            "TER",
            "TG",
            "TOO",
            "TM"});
            this.cbb_curso.Location = new System.Drawing.Point(303, 76);
            this.cbb_curso.Name = "cbb_curso";
            this.cbb_curso.Size = new System.Drawing.Size(121, 24);
            this.cbb_curso.TabIndex = 6;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(713, 294);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(363, 415);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // trv_insc
            // 
            this.trv_insc.AllowDrop = true;
            this.trv_insc.Location = new System.Drawing.Point(15, 323);
            this.trv_insc.Name = "trv_insc";
            this.trv_insc.Size = new System.Drawing.Size(773, 86);
            this.trv_insc.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-Female-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-Male-50.png");
            // 
            // btn_inscrever
            // 
            this.btn_inscrever.Enabled = false;
            this.btn_inscrever.Location = new System.Drawing.Point(713, 150);
            this.btn_inscrever.Name = "btn_inscrever";
            this.btn_inscrever.Size = new System.Drawing.Size(75, 23);
            this.btn_inscrever.TabIndex = 10;
            this.btn_inscrever.Text = "Inscrever";
            this.btn_inscrever.UseVisualStyleBackColor = true;
            this.btn_inscrever.Click += new System.EventHandler(this.btn_inscrever_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_inscrever);
            this.Controls.Add(this.trv_insc);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.cbb_curso);
            this.Controls.Add(this.lbl_insc);
            this.Controls.Add(this.grb_sexo);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.lbl_num);
            this.Name = "Form1";
            this.Text = "Inscrições (Tree View)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_sexo.ResumeLayout(false);
            this.grb_sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.GroupBox grb_sexo;
        private System.Windows.Forms.RadioButton rdb_fem;
        private System.Windows.Forms.RadioButton rdb_masc;
        private System.Windows.Forms.Label lbl_insc;
        private System.Windows.Forms.ComboBox cbb_curso;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TreeView trv_insc;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_inscrever;
    }
}

