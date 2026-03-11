namespace exExtra
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
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAutonomia = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbbAutonomia = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grbHD = new System.Windows.Forms.GroupBox();
            this.rdbS = new System.Windows.Forms.RadioButton();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.lstbInsc = new System.Windows.Forms.ListBox();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.grbHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 9);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(53, 16);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAutonomia
            // 
            this.lblAutonomia.AutoSize = true;
            this.lblAutonomia.Location = new System.Drawing.Point(9, 81);
            this.lblAutonomia.Name = "lblAutonomia";
            this.lblAutonomia.Size = new System.Drawing.Size(103, 16);
            this.lblAutonomia.TabIndex = 1;
            this.lblAutonomia.Text = "Autonomia (min)";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 28);
            this.txtModelo.MaxLength = 128;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // cbbAutonomia
            // 
            this.cbbAutonomia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAutonomia.FormattingEnabled = true;
            this.cbbAutonomia.Items.AddRange(new object[] {
            "30",
            "60",
            "180",
            "240",
            "300"});
            this.cbbAutonomia.Location = new System.Drawing.Point(12, 100);
            this.cbbAutonomia.Name = "cbbAutonomia";
            this.cbbAutonomia.Size = new System.Drawing.Size(121, 24);
            this.cbbAutonomia.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(171, 101);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // grbHD
            // 
            this.grbHD.Controls.Add(this.rdbN);
            this.grbHD.Controls.Add(this.rdbS);
            this.grbHD.Location = new System.Drawing.Point(279, 16);
            this.grbHD.Name = "grbHD";
            this.grbHD.Size = new System.Drawing.Size(200, 108);
            this.grbHD.TabIndex = 5;
            this.grbHD.TabStop = false;
            this.grbHD.Text = "Camera HD";
            // 
            // rdbS
            // 
            this.rdbS.AutoSize = true;
            this.rdbS.Checked = true;
            this.rdbS.Location = new System.Drawing.Point(17, 35);
            this.rdbS.Name = "rdbS";
            this.rdbS.Size = new System.Drawing.Size(51, 20);
            this.rdbS.TabIndex = 0;
            this.rdbS.TabStop = true;
            this.rdbS.Text = "SIM";
            this.rdbS.UseVisualStyleBackColor = true;
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(17, 61);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(54, 20);
            this.rdbN.TabIndex = 1;
            this.rdbN.Text = "Não";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // lstbInsc
            // 
            this.lstbInsc.FormattingEnabled = true;
            this.lstbInsc.ItemHeight = 16;
            this.lstbInsc.Location = new System.Drawing.Point(12, 153);
            this.lstbInsc.Name = "lstbInsc";
            this.lstbInsc.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbInsc.Size = new System.Drawing.Size(467, 228);
            this.lstbInsc.TabIndex = 2;
            // 
            // btnElim
            // 
            this.btnElim.Enabled = false;
            this.btnElim.Location = new System.Drawing.Point(15, 404);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(75, 23);
            this.btnElim.TabIndex = 6;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(393, 404);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(75, 23);
            this.btnMedia.TabIndex = 7;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.lstbInsc);
            this.Controls.Add(this.grbHD);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cbbAutonomia);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblAutonomia);
            this.Controls.Add(this.lblModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Drones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbHD.ResumeLayout(false);
            this.grbHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAutonomia;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbbAutonomia;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grbHD;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.RadioButton rdbS;
        private System.Windows.Forms.ListBox lstbInsc;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnMedia;
    }
}

